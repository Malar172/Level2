List<string> Products = new List<string>();
while (true)
{
    Console.WriteLine("Enter product names" +".");
    Console.WriteLine("Type 'exit' to finish" +".");
    Console.Write("Product:");

    string product = Console.ReadLine().Trim();
    if(product.ToLower() == "exit")
    {
        break;
    }
    
    Products.Add(product);
}

 Products.Sort();

Console.WriteLine("Sorted product list: ");

foreach(string product in Products)
{
    Console.WriteLine("Product: " + product);
}
Console.ReadLine();
