using Aula125.Entites;
using Aula125.Entites.Exceptions;
using System.Globalization;


try { 
Console.Write("Room Number: ");
int roomNumber = int.Parse(Console.ReadLine());

Console.Write("Check-in date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());

Console.Write("Check-out date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());

Reservantion reservantion = new Reservantion(roomNumber, checkIn, checkOut);

Console.WriteLine("Reservation : " + reservantion);

Console.WriteLine();

Console.WriteLine("Enter data to update the reservation: ");

Console.Write("Check-in date (dd/MM/yyyy): ");
checkIn = DateTime.Parse(Console.ReadLine()); 

Console.Write("Check-out date (dd/MM/yyyy): ");
checkOut = DateTime.Parse(Console.ReadLine());

    reservantion.UpdateDates(checkIn, checkOut);

Console.WriteLine("Reservation : " + reservantion);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}