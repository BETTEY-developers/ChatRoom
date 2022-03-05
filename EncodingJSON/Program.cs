using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string arg = args[0];
File file = JsonSerializer.Deserialize<File>(arg);
Console.WriteLine($"[{file.Name}][{file.Id}][{file.Size}]");
class File
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Size { get; set; }
}