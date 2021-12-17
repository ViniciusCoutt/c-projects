using ProductCategory_LINQwLambda.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>() {
    new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
    new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
    new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
    new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
    new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
    new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
    new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
    new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
    new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
    new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
    new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
};

var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
Print("TIER 1 AND PRICE MENOR QUE 900", r1);

var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
Print("NAMES OF PRODUCTS FROM TOOLS", r2);

// Criação de um objeto anonimo (que não está declarado), algo específico. 
// Como temos dois campos com o mesmo nome temos que criar um apelido (alias). Podemo colocar um alias em todos os elementos
var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); ;
Print("NAMES STARTED WITH 'C' AND ANONYMOUES OBJECT", r3);

// Ordenação por preço(prioridade) e depois por nome
var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
Print("TIER 1 ORDERED BY PRICE THEN BY NAME: ", r4);

// Pula 2 elementos e monstra 4
var r5 = r4.Skip(2).Take(4);
Print("TIER 1 ORDERED BY PRICE THEN BY NAME, SKIPED 2 AND TAKED 4: ", r5);

// O FirstOrDefault nos poupa de ter que tratar a excessão por não ter valor. Se não houver valor retorna nulo.
var r6 = products.First();
Console.WriteLine("First or default test1: " + r6);
var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
Console.WriteLine("First or default test2: " + r6); // First or default test2:  

// Com o SingleOrDefault é retornado um elemento Product, já sem ele retorna uma coleção INumerable
// O SingleOrDefault não funciona se retornar mais de um valor
var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("\nSingle or default test1: " + r8);
// Retorna nullo se não encontrar
var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test1: " + r9);

// Funções de agregação pré definidas: 
var r10 = products.Max(p => p.Price);
Console.WriteLine("\nMax Price: " + r10);
var r11 = products.Min(p => p.Price);
Console.WriteLine("Min Price: " + r11);
var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 Sum prices: " + r12);
var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Avarage prices: " + r13);
// Tratamento se o valor é nulo:
var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Category 5 Avarage prices: " + r14);

//[Operação Agragada Personalizada] - Select/Agregate (MapReduce em outras linguagens)
var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
Console.WriteLine("Category 1 aggregate sum: " + r15);
// Tratamento dos argumentos por atribuição de valor inicial padrão
var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Category 5 aggregate sum: " + r16);

// Operação de agrupamento; Agrupa por chave e coleção de elementos. PS: Pode ser (var group in r17)
var r17 = products.GroupBy(p => p.Category);
foreach (IGrouping<Category, Product> group in r17)
{
    Console.WriteLine("\nCategory " + group.Key.Name + ":");
    foreach(Product p in group)
    {
        Console.WriteLine(p);
    }
}
