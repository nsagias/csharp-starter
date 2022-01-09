using System.IO;
using System.Text.Encodings;
using System.Collections.Generic; 
using Newtonsoft.Json;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var createNewDirectoryName = "salesTotalDirectory";
// var createNewFileName = "totals.txt";
// var createNewFileContent =  String.Empty;
// var createNewFileContent =  "Nick was here";



var salesTotalDirectory = Path.Combine(currentDirectory, createNewDirectoryName  );

Directory.CreateDirectory(salesTotalDirectory);

var fileExtension = ".json";
var salesFiles = FindFiles(storesDirectory, fileExtension);

// File.WriteAllText(Path.Combine(salesTotalDirectory, createNewFileName), createNewFileContent );

var salesTotal = CalculateSalesTotal(salesFiles);
var updateExistingFileName = "totals.txt";
var updateExistingFileContent = $"{salesTotal}{Environment.NewLine}";
File.AppendAllText(
    Path.Combine(salesTotalDirectory, updateExistingFileName), updateExistingFileContent);



IEnumerable<string> FindFiles(string folderName, string fileExtension) {
  List<string> salesFiles = new List<string>();

  var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
  
  foreach (var file in foundFiles) {
    var extension = Path.GetExtension(file);
    if (extension == fileExtension) {
      salesFiles.Add(file);
    }
  }
  return salesFiles;
}


foreach (var file in salesFiles) {
  Console.WriteLine(file);
}



double CalculateSalesTotal(IEnumerable<string> salesFiles) {
  double salesTotal = 0;

  foreach (var file in salesFiles) {
    string salesJson = File.ReadAllText(file);

    SalesData? data = JsonConvert.DeserializeObject<SalesData>(salesJson);

    salesTotal += data?.Total ?? 0;
  }

  return salesTotal;
}
record SalesData (double Total);

