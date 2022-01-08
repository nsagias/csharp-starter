using System.IO;
using System.Collections.Generic; 

IEnumerable<string> FindFiles(string folderName) {
  List<string> salesFiles = new List<string>();

  var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
  
  foreach (var file in foundFiles) {
    if (file.EndsWith("sales.json")) {
      salesFiles.Add(file);
    }
  }
  return salesFiles;
}

var salesFiles = FindFiles("stores");

foreach (var file in salesFiles) {
  Console.WriteLine(file);
}

// get root 
string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(documentPath);

// directory notation
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

// Combine to form path
Console.WriteLine(Path.Combine("stores","201")); 

// get filename extension
Console.WriteLine(Path.GetExtension("sales.json"));