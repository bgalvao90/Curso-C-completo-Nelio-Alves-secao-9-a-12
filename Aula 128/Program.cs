using Aula_128.Entities;
using Aula_128.Entities.Enums;
using System.Globalization;

List <Shape> list = new List<Shape>();


Console.Write("Enter the number of shapes: ");
int shapesCount = int.Parse(Console.ReadLine());

for (int i = 1; i <= shapesCount; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.Write("Rectangle or Circle (r/c)? ");
    char shapeType = char.Parse(Console.ReadLine());

    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (shapeType == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Rectangle(width, height, color));

    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Circle(radius, color));
    }
}
Console.WriteLine();
Console.WriteLine("SHAPE AREAS: ");

foreach (Shape shape in list)
{
    Console.WriteLine($"Shape area: {shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
}