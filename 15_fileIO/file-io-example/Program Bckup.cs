// using System.IO;
// using System.Text.Encodings;
// using System.Collections.Generic; 

// IEnumerable<string> FindFiles(string folderName, string fileExtension) {
//   List<string> salesFiles = new List<string>();

//   var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
  
//   foreach (var file in foundFiles) {
//     // if (file.EndsWith("sales.json")) {
//     //   salesFiles.Add(file);
//     // }
//     var extension = Path.GetExtension(file);
//     // if (extension == ".json") {
//     //   salesFiles.Add(file);
//     // }
//     if (extension == fileExtension) {
//       salesFiles.Add(file);
//     }
//   }
//   return salesFiles;
// }

// // var salesFiles = FindFiles("stores");



// // foreach (var file in salesFiles) {
// //   Console.WriteLine(file);
// // }

// // get root 
// string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
// Console.WriteLine(documentPath);

// // directory notation
// Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

// // Combine to form path
// Console.WriteLine(Path.Combine("stores","201")); 

// // get filename extension
// Console.WriteLine(Path.GetExtension("sales.json"));



// // directory info
// string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

// FileInfo info = new FileInfo(fileName);

// Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}");

// // get current directory
// var currentDirectory = Directory.GetCurrentDirectory();
// Console.WriteLine(currentDirectory);

// // use current directory and add stores to path
// var storesDirectory = Path.Combine(currentDirectory, "stores");
// Console.WriteLine(storesDirectory);

// var fileExtension = ".json";

// var salesFiles = FindFiles(storesDirectory, fileExtension);


// foreach (var file in salesFiles) {
//   Console.WriteLine(file);
// }


// // creating new directories
// Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newMadeDir"));

// // check if diretory exists  reuse current directory
// // var currentDirectory = Directory.GetCurrentDirectory();
// var filePath = Path.Combine(currentDirectory, "stores", "201","newMadeDir");
// bool directoryExists = Directory.Exists(filePath);
// Console.WriteLine($"Return boolean {directoryExists}");

// // create new file and add text to the file
// // reuse filePath
// // must use pathcombine
// File.WriteAllText(Path.Combine(filePath, "Hello.txt"), "Hello World Nick!");