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




    }
}
