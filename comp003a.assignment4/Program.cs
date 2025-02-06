using System.Transactions;

namespace comp003a.assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the inventory management");
            Console.WriteLine("Choose your storage method: ");
            Console.WriteLine("1. Arrays");
            Console.WriteLine("2. Lists");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                UseArrays();
            }
            else if (choice == 2)
            {
                UseLists();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void UseArray()
        {
            string[] productName = new string[10];
            int[] quantities = new int[10];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View inventory");
                Console.WriteLine("4. Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if (count >= 10)
                        {
                            Console.WriteLine("Inventory is full. Cannot add more products");
                            break;
                        }
                        Console.Write("Enter product name: ");
                        String name = Console.ReadLine();
                        Console.Write("Enter product quantity");
                        int quantity = int.Parse(Console.ReadLine());

                        productName[count] = name;
                        quantities[count] = quantity;
                        count++;
                        Console.WriteLine("Product added.");
                        break;

                }

            }
        }


    }
}
