// // achar o diretório
var currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);
// // diretório existente
var storesDirectory = Path.Combine(currentDirectory, "stores");

// // criar diretório
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir", "newDir");
Directory.CreateDirectory(salesTotalDir);

// criar arquivos
File.WriteAllText(Path.Combine(salesTotalDir, "greeting.txt"), "Hello");

// verificar se o diretório existe
bool doesDirectoryExist = Directory.Exists(salesTotalDir);
Console.WriteLine(doesDirectoryExist);

// // colocar dentro da pasta stores
var salesFiles = FindFiles(storesDirectory);

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

// // criar arquivo txt
// File.WriteAllText(Path.Combine(salesTotalDir, "total.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // verifica a versão do arquivo
        var extension = Path.GetExtension(file);
        if (extension == ".txt")
        {
            salesFiles.Add(file);
        }
    }
    return salesFiles;
}

// consultar diretório
IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("salesTotalDir");

foreach (var dir in listOfDirectories)
{
    Console.WriteLine(dir);
}

// consultar arquivos
IEnumerable<string> files = Directory.EnumerateFiles("salesTotalDir");

foreach (var file in files)
{
    Console.WriteLine(file);
}

IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("salesTotalDir", "*.txt", SearchOption.AllDirectories);

foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}













// Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201"));

// criar arquivo
// File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt", "Hello World!");)

// verificar se o diretório existe
// bool doesDirectoryExist = Directory.Exists(filePath);
