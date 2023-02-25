string fileInputName = @"school1_list_program.xml";

Console.WriteLine("Положите исходный .xml файл в папку с этой программой");
Console.Write("Введите имя файла с расширением. По умолчанию будет использованно имя 'school1_list_program.xml' : ");

fileInputName = Console.ReadLine();

if (fileInputName == null || fileInputName == "")
{
    fileInputName = @"school1_list_program.xml";
}

try
{
    Console.WriteLine(Convert.ToBase64String(File.ReadAllBytes(fileInputName)));
    Console.WriteLine("Скопируйте содержимое окна в тестовый файл с расширением .sft");
}
catch
{
    Console.WriteLine("Файл с таким именем не найден.");
}