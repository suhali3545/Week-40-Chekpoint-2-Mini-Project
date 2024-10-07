

using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using Stripe;
using Stripe.Climate;
using Stripe.Issuing;
using System.Data;
using System.Linq;

class program
{
    static void Main(string[] args)
    {

        List<Product> Products = new List<Product>();
        string input = "";
        Console.WriteLine("To enter a new product - follw the steps | To quit - enter: ``Q`` ");
        while (true)
        {

            Console.Write("Enter a Product Name: ");
            string productname = Console.ReadLine();
            if (string.IsNullOrEmpty(productname))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("product name cannot be empty ");
                {
                    Console.ResetColor();
                }

            }
            Console.Write("Enter a category: ");
            string categoryname = Console.ReadLine();
            if (string.IsNullOrEmpty(categoryname))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("category cannot be empty ");
                Category category = new Category(categoryname);

                {
                    Console.ResetColor();
                }

            }

            Console.Write("Enter a Price: ");
            decimal Price = decimal.Parse(Console.ReadLine());
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Invalid price, please try again.");
            }

            Products.AddRange(Products);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product was succefully added!");
            Console.ResetColor();

            Console.WriteLine("\nDo you want to add more products?(Press any key to continue  or 'q' to quit): ");
            input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }

            else
            {
                Main(args);
            };


            Console.WriteLine("-------------------------------------");
            List<Product> sortedproducts = Products.OrderBy(product => product.Price).ToList();
            var sortedProducts = Products.OrderBy(p => p.Price);

            foreach (Product product in sortedproducts)
            {
                Console.WriteLine(product.Name.PadRight(10) + product.Category.PadRight(10) + product.Price);
            }
            decimal totalPrice = sortedproducts.ToList().Sum(product => product.Price);
            Console.WriteLine("$\nTotal Price: { totalPrice:c}");


            Console.WriteLine("-------------------------------------");
            List<Product> filteredproducts = Products.Where(Product => Product.Price > totalPrice).ToList();
            foreach (Product product in filteredproducts)
            {
                Console.WriteLine(product.Name.PadRight(10) + product.Category.PadRight(10) + product.Price);
            }

           




        }


    }
    static void DisplayProducts(List<Product> products)

    {
        var sortedProducts = products.OrderBy(p => p.Price);

        foreach (Product product in sortedProducts)
        {
            Console.WriteLine(product);
        }
       
    }

    static void SerchProducts(List<Product> products)
    {
        Console.Write("Enter S to search: ");
        string searchQeury = Console.ReadLine().ToLower();
        var foundProducts = products.Where(p => p.Name.ToLower().Contains(searchQeury) || p.Category.ToLower().Contains(searchQeury));
        if (foundProducts.Count()> 0)
        {
            Console.WriteLine("\nSearch Resuls:");
            Console.WriteLine("---------------------------------------------");
            foreach (var product in foundProducts)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine("No products found. ");
        }
    }


    
}

    class Product
    {
        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    class Category
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
