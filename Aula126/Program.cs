﻿using Aula126.Entities;
using Aula126.Entities.Exceptions;
using System.Globalization;
try
{
    Console.WriteLine("Enter account data");

    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account acc = new Account(number, holder, balance, withdrawLimit);
    

    Console.WriteLine();

    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    acc.WithDraw(amount);

    Console.WriteLine(acc);
}

catch (DomainException e) 
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}