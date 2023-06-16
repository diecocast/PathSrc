Console.WriteLine("Copia el path al que deseas navegar: ");
string path = Console.ReadLine();
string[] files = Directory.GetFiles(path);
string[] folders = Directory.GetDirectories(path);

Console.WriteLine("Estos son los archivos: \n");
foreach (string file in files)
{
    string filter = file.Replace(path, "-");
    Console.WriteLine($"\t {filter}");
}


Console.WriteLine("Estas son las carpetas: \n");
foreach (string folder in folders)
{
    string filter = folder.Replace(path, "-");
    Console.WriteLine($"\t {filter}");
}

Console.ReadKey();