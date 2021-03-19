using System;
using System.IO;

var destination = @"C:\Users\uxsoft\Desktop\";
var template = @"C:\Users\uxsoft\Desktop\template.xlsx";
var names = @"
asd
asd1
asd2
asd3
asd4
";

Console.WriteLine($"Using template: {template}");

foreach (var name in names.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries))
{
    var fileName = Path.Combine(destination, $"{name.Trim()}.xlsx");
    File.Copy(template, fileName);
    Console.WriteLine($"Created {fileName}");
}

Console.WriteLine("Finished creating files!");
Console.ReadKey();