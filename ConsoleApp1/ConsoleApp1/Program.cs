// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");
Console.WriteLine("=======================");
//Date date1 = new Date(2022, 2, 11);



//try
//{
//    Console.WriteLine(new Date(2022, 11, 30));
//    Console.WriteLine(new Date(2022, 9, 23));
//    Console.WriteLine(new Date(2024, 11, 29));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1985, 3, 14),
    HiringDate = new Date(2022, 2, 10), //    inicio de actividades
    IsActive = true,        //es Activa
    Salary = 154648.45M
};
Employee employee2 = new CommissionEmployee()
{
    Id = 1020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1984, 3, 14),
    HiringDate = new Date(2022, 2, 10), //    inicio de actividades
    IsActive = true,        //es Activa
    //Salary = 154648.45M,
    Sales = 1564651M,
    CommissionPercentaje = 0.03F
};

Console.WriteLine(employee1);
Console.WriteLine(employee2);