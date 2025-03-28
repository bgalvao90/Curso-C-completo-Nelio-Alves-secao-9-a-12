using Aula119.Entities;
using System.Globalization;
using System.Collections.Generic;
using System;


List<Person> list = new List<Person>();

Console.Write("Enter the number of tax payers: ");
int taxPayers = int.Parse(Console.ReadLine());

for (int i = 1; i <= taxPayers; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");

    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());

    if (type == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Annual income: ");
        double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Health expenditures: ");
        double healthExpendt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Individual(name, annualIncome, healthExpendt));
    }
    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Annual income: ");
        double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Number of employees: ");
        int employee = int.Parse(Console.ReadLine());

        list.Add(new Company(name, annualIncome, employee));
    }

}
Console.WriteLine();
double sum = 0.0;
Console.WriteLine("TAXES PAID: ");
foreach (Person person in list)
{
    double tax = person.Tax();
    Console.WriteLine(person.Name + ": $ " + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
    sum += tax;

}

Console.WriteLine();

Console.WriteLine( $"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");