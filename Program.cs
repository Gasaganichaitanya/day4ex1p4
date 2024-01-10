// See https://aka.ms/new-console-template for more information
using ConAppTwo;

Console.WriteLine("Hello, World!");
List<Employee> employees = new List<Employee>()
{
    new Employee() { Id=1,Name="sam",Designation="Manager",DOJ= new DateTime(day:12,month:11,year:2022)},
    new Employee() { Id=2,Name="ram",Designation="Tester",DOJ= new DateTime(day:12,month:11,year:2022)},
    new Employee() { Id=3,Name="Jagan",Designation="Developer",DOJ= new DateTime(day:12,month:11,year:2022)},
    new Employee() { Id=4,Name="Chandra",Designation="Manager",DOJ= new DateTime(day:12,month:11,year:2022)},
    new Employee() { Id=5,Name="firoz",Designation="Developer",DOJ= new DateTime(day:12,month:11,year:2021)},
};
Console.WriteLine("ID\tName\tDesignation\tDate of Joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t\t");
    Console.Write(emp.Name + "\t\t");
    Console.Write(emp.Designation + "\t\t");
    Console.WriteLine(emp.DOJ.ToLongDateString());
    Console.WriteLine("\n");
}

