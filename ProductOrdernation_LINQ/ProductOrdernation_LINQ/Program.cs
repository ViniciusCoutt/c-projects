
using ProductOrdernation_LINQ.Entities;
using System.Globalization;
using System.Linq;

static void Print<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

using (StreamReader sr = File.OpenText(path))
{
    List<Product> products = new List<Product>();

    while (!(sr.EndOfStream))
    {
        string[] line = sr.ReadLine().Split(',');
        string name = line[0];
        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
        products.Add(new Product(name, price));
    }

    var avarage = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

    Console.WriteLine("Avarage price: " + avarage.ToString("F2"));

    var result = products.Where(p => p.Price < avarage).OrderByDescending(p => p.Name).Select(p => p.Name);

    Print(result);

}



