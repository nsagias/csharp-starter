using System.IO;
using System.Text.Encodings;
using System.Collections.Generic; 



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




// get current directory
var currentDirectory = Directory.GetCurrentDirectory();

// use current directory and add stores to path
var storesDirectory = Path.Combine(currentDirectory, "stores");

var fileExtension = ".json";

var salesFiles = FindFiles(storesDirectory, fileExtension);


foreach (var file in salesFiles) {
  Console.WriteLine(file);
}


// creating new directories
Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newMadeDir"));

// check if diretory exists  reuse current directory
// var currentDirectory = Directory.GetCurrentDirectory();
var filePath = Path.Combine(currentDirectory, "stores", "201","newMadeDir");
bool directoryExists = Directory.Exists(filePath);
Console.WriteLine($"Return boolean {directoryExists}");

