using System.IO;
using System.Text.Encodings;
using System.Collections.Generic; 



var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var createNewDirectoryName = "salesTotalDirectory";
var createNewFileName = "totals.txt";
var fileExtension = ".json";

var salesTotalDirectory = Path.Combine(currentDirectory, createNewDirectoryName  );

Directory.CreateDirectory(salesTotalDirectory);

var salesFiles = FindFiles(storesDirectory, fileExtension);

File.WriteAllText(Path.Combine(salesTotalDirectory, createNewFileName), String.Empty);



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


