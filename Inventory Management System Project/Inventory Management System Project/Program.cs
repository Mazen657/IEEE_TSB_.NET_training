namespace Inventory_Management_System_Project
{
    internal class Program
    {
        const int numberofProducts = 50;

        static string[,] Inventory = new string[numberofProducts, 3];

        static int productcount = 0;

        static void Main(string[] args)
        {
            //Add Product
            //Update Product
            //View Product (ID , Name , Quantity , Price)
            //Exit

            Console.WriteLine("Welcome To The Inventory Management System");
            Console.WriteLine("==========================================");
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. View Product");
                Console.WriteLine("4. Exit");

                string userInput = Console.ReadLine();
                var choice = Convert.ToInt32(userInput);

                switch (choice)
                {
                    case 1:
                        //Add Product
                        AddProduct();
                        break;
                    case 2:
                        //Update Product
                        UpdateProduct();
                        break;
                    case 3:
                        //View Product
                        ViewProducts();
                        break;
                    case 4:
                        //Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter number from 1 to 4 only");
                        break;
                }
            }
            
        }
        private static void AddProduct()
        {

            Console.WriteLine("Enter Porduct Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Porduct Quantity");
            string Quantity = Console.ReadLine();

            Console.WriteLine("Enter Porduct Price");
            string Price = Console.ReadLine();

            Inventory[productcount,0]  = Name;
            Inventory[productcount, 1] = Quantity;
            Inventory[productcount, 2] = Price;

            productcount++;

            Console.WriteLine("Prodect added successefuly");
        }

        private static void ViewProducts()
        {
            if (productcount > 0)
            {
                Console.WriteLine("Product List: ");
                for (int i = 0; i < productcount; i++)
                {

                    Console.WriteLine($"Product ID: {i}\n "       +
                        $"Product Name: {Inventory[i, 0]}\n "     +
                        $"Product Quantity: {Inventory[i, 1]}\n " +
                        $"Product Price: {Inventory[i, 2]}\n\n");
                }
            }
            else
            { Console.WriteLine("\nPlease Enter The Products frist\n"); }
        }

        private static void UpdateProduct()
        {
            int ProductID = -1;
            bool OutForLoop = true;

            if (productcount > 0)
            {
                Console.WriteLine("Enter Product Name to Update");
                string ProductName = Console.ReadLine();


                for (int i = 0; i < productcount; i++)
                {
                    if (ProductName == Inventory[i,0])
                    {
                        ProductID = i;
                        break;
                    }
                }
                if(ProductID != -1)
                {
                    while (OutForLoop)
                    {
                        Console.WriteLine("Which Want You Update\n" +
                        "1. Update Name\n" +
                        "2. Update Quantity\n" +
                        "3. Update Prise\n");
                        var Choise = Convert.ToInt32(Console.ReadLine());
                        switch (Choise)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                string newName = Console.ReadLine();

                                Inventory[ProductID, 0] = newName;
                                OutForLoop = false;
                                break;
                            case 2:
                                Console.WriteLine("Enter the new quantity");
                                string newQuantity = Console.ReadLine();

                                Inventory[ProductID, 1] = newQuantity;
                                OutForLoop = false;
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price");
                                string newPrice = Console.ReadLine();

                                Inventory[ProductID, 2] = newPrice;
                                OutForLoop = false;
                                break;
                            default:
                                Console.WriteLine("Please Enter number from 1 to 4 only");
                                break;
                        }
                    }
                }
            }
            else
            { Console.WriteLine("\nPlease Enter The Products frist\n"); }
        }
    }
}
