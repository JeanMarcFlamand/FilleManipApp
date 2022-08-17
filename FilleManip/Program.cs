// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string newPath = @"C:\Temp\Demos\FileSystem\SubfolderA\SubfolderAA\SubFolderZZ";
string rooPath = @"C:\Temp\Demos\FileSystem";

//string [] dirs = Directory.GetDirectories(rooPath,"*",SearchOption.AllDirectories);
//Console.WriteLine(dirs.Length);
//Console.WriteLine(dirs.GetValue(1));
//foreach (string dir in dirs)
//{
//    Console.WriteLine(dir);
//}


//string [] files = Directory.GetFiles(rooPath,"*",SearchOption.AllDirectories);
//foreach (string file in files)
//{
//    //Console.WriteLine(file);
//    //Console.WriteLine(Path.GetFileName(file));
//    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
//    var fileInfo = new FileInfo(file);

//    Console.WriteLine($"{Path.GetFileName(file)} , {fileInfo.Length.ToString()} bytes");
//}

//bool directotyExist = Directory.Exists(newPath);

//    if (directotyExist)
//    {
//    Console.WriteLine($"The directory Exist");
//    }
//    else
//    {
//        Console.WriteLine($"The directory doesn't Exist");
//        Directory.CreateDirectory(newPath);
//    }

// CreateDirectory do not required to check if directory exist
// Directory.CreateDirectory(newPath);

//working with files
//copy files
string[] files = Directory.GetFiles(rooPath);
string destinationFolder = @"C:\Temp\Demos\FileSystem\SubfolderA\SubfolderAA\SubFolderZZ\";

//foreach (string file in files)
//{
//    File.Copy(file,$"{ destinationFolder} {Path.GetFileName(file)}", true);
//}


//copy files and rename them
//for (int i = 0; i < files.Length; i++)
//{
//    File.Copy(files[i], $"{destinationFolder} ToTo{i}.txt", true);
//}

//Move files
foreach (string file in files)
{
    File.Move(file, $"{destinationFolder} {Path.GetFileName(file)}", true);
}

//video completed
Console.ReadLine();