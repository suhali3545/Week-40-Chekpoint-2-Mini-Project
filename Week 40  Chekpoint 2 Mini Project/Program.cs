
    //Console.WriteLine(isInt);
    //Console.WriteLine(value);
    //Array.Resize(ref valueArray, valueArray.Length + 1);
    ////valueArray[index] = int.Parse(data);
    //valueArray[index] = Convert.ToInt32(data);
    //index++;


    //}

    //Console.WriteLine("---------------");
    //Console.WriteLine("Your Numbers");
    //foreach (int element in valueArray)
    //{
    //    Console.WriteLine(element);
    //}


    //Console.WriteLine("---------------");
    //Console.WriteLine("Your Numbers - Sorted");
    //Array.Sort(valueArray);
    //foreach (int element in valueArray)
    //{
    //    Console.WriteLine(element);
    //}

    //Console.ReadLine();
    //if (string.IsNullOrEmpty(data))
    //{
    //    Console.ForegroundColor = ConsoleColor.Red;
    //    Console.WriteLine("Du får inte ange ett tomt värde ");

    //    {
    //        Console.ResetColor();
    //    }






    List<product> productlist = new List<product>();

    Console.WriteLine("To enter a new product - follw the steps | To quit - enter: ``Q`` ");
while (true)

{
    //string data = Console.ReadLine();
    Console.Write("Enter a Category: ");
    string categoryName = Console.ReadLine();
    if (string.IsNullOrEmpty(categoryName))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Category cannot be empty ");
        Category category = new Category(categoryName);

        {
            Console.ResetColor();
        }
        //if (string
        //    {
        //    data == "Q")
        //    }

        //{
        //        break;
        //    }


        //string data = Console.ReadLine();
        Console.Write("Enter Product name: ");
        string productName = Console.ReadLine();
        if (string.IsNullOrEmpty(productName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("product name cannot be empty ");
            //Name Name = new Name(Name);

            {
                Console.ResetColor();
            }
            //if (data == "Q")

            //{
            //    break;
            //}
        }
    }
}









    class Category
{
    public Category(string name)
    {
        name = name;
    }
    public Category name { get; set; }
}

class product
{
    public product()
    {
    }

    public product(string Name, string Category, int Prise)
    {
        Name = Name;
        Category = Category;
        Prise = Prise;

    }

    public string Name { get; set; }
    public string Category { get; set; }
    public int Prise { get; set; }
}
