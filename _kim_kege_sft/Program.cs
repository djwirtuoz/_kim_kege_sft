string fileInputName = @"list_program.xml";

Console.WriteLine("Нажмите ENTER");
Console.ReadLine();

try
{
    Console.WriteLine(Convert.ToBase64String(File.ReadAllBytes(fileInputName)));
    Console.WriteLine("Скопируйте содержимое окна в тестовый файл с расширением .sft");
}
catch
{
    Console.WriteLine("Файл не найден."); Console.ReadLine();
}

Console.ReadLine();