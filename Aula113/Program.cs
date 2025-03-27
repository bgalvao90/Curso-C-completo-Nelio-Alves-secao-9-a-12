using System.Xml.Linq;
using System.Globalization;
using System.Collections.Generic;
using Aula113.Entities;

List<Employee> list = new List<Employee>();



Console.Write("Enter the number of employees: ");
int employeeCount = int.Parse(Console.ReadLine());


for (int i = 1; i <= employeeCount; i++)
{
    Console.WriteLine($"Employee #{i} data: ");

    Console.Write("Outsourced (y/n)? ");
    char Outsorced = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string employeeName = Console.ReadLine();

    Console.Write("Hours: ");
    int employeeHours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double empValueph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (Outsorced == 'y')
    {
        Console.Write("Additional Charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutSoucedEmployee(employeeName, employeeHours, empValueph, additionalCharge));
    }
    else
    {
        list.Add(new Employee(employeeName, employeeHours, empValueph));
    }
}
Console.WriteLine("PAYMENTS: ");
foreach (Employee emp in list)
{

    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
}