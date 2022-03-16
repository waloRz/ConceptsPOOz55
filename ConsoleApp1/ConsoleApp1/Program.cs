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

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Jose",
    LastName = "Colodro",
    BirthDate = new Date(1984, 3, 14),
    HiringDate = new Date(2022, 2, 10), //    inicio de actividades
    IsActive = true,        //es Activa    
    Hours = 80,
    HourValue= 1000M
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Mario",
    LastName = "Flores",
    BirthDate = new Date(1984, 3, 14),
    HiringDate = new Date(2022, 2, 10), //    inicio de actividades
    IsActive = true,        //es Activa    
    Sales = 40000M,
    CommissionPercentaje = 0.015F,
    Base = 50000M
};

//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                             =====================");
Console.WriteLine($"TOTAL                          {$"{payroll:c2}", 18}");

Invoice factura1 = new Invoice()
{
    Id = 123,
    Descripcion = "xiomi",
    Price = 56832M,
    Quantity = 2
};

Invoice factura2 = new Invoice()
{
    Id = 475,
    Descripcion = "carne",
    Price = 1123M,
    Quantity = 6.5F
};                  

Console.WriteLine(factura1);    
Console.WriteLine(factura2);    

//employees.Add(employee1);
//employees.Add(employee2);   
//employees.Add(employee3);
//employees.Add(employee4);


