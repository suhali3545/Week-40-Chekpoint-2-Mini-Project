
using DocumentFormat.OpenXml.Wordprocessing;
using Stripe;
using Stripe.Issuing;
using System.Data;

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


            Products.AddRange(Products);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product was succefully added!");
            Console.ResetColor();

            Console.Write("Type 'q' to quit or any other key to add another produkt: ");
            input = Console.ReadLine();


            Console.WriteLine("-------------------------------------");
            List<Product> sortedproducts = Products.OrderBy(product => product.Price).ToList();
            var sortedProducts = Products.OrderBy(p => p.Price);
         
            foreach (Product product in sortedproducts)
            {
                Console.WriteLine(product.Name.PadRight(10) + product.Category.PadRight(10) + product.Price);
            }
            decimal totalPrice = sortedproducts.ToList().Sum(product => product.Price);
            Console.WriteLine("$\nTotal Price: { totalPrice:c}" );


            Console.WriteLine("-------------------------------------");
            List<Product> filteredproducts = Products.Where(Product => Product.Price > totalPrice).ToList();
            foreach (Product product in filteredproducts)
            {
                Console.WriteLine(product.Name.PadRight(10) + product.Category.PadRight(10) + product.Price);
            }

            Console.WriteLine("\nDo you want to add more products?(Press any key to continue  or 'q' to quit): ");
           
            input = Console.ReadLine();
            if (input == "q")
            {
                break; 
            }

            else
            {
                Main(args);
            }
           
            
           

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

}
