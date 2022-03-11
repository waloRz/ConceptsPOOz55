// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");
Console.WriteLine("=======================");
//Date date1 = new Date(2022, 2, 11);



try
{
    Console.WriteLine(new Date(2022, 11, 30));
    Console.WriteLine(new Date(2022, 9, 23));
    Console.WriteLine(new Date(2024, 11, 29));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}