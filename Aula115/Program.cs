using System.Collections.Generic;
using System.Globalization;
using Aula115.Entities;

List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int productCount = int.Parse(Console.ReadLine());

for  (int i = 1; i <= productCount; i++)
{
    Console.WriteLine($"Product #{i} data:");

    Console.Write("Common, user or imported (c/u/i)? ");
    char productCUI = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string productName = Console.ReadLine();

    Console.Write("Price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (productCUI == 'i')
    {
        Console.Write("Customs fee: ");
        double productCustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(productName, productPrice, productCustomsFee));
    }
    else if (productCUI == 'u')
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime productManDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(productName, productPrice, productManDate));   
    }
    else
    {
        list.Add(new Product(productName, productPrice));
    }

  
}

Console.WriteLine("PRICE TAGS: ");
foreach (Product product in list)
{
    Console.WriteLine($"{product.priceTag()}");
}