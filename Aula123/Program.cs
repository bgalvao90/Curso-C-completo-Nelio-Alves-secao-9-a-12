

try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int result = n1 / n2;
    Console.WriteLine("Sum = " + result);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Error: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}
finally
{
    Console.WriteLine("Finally block is executed");
}