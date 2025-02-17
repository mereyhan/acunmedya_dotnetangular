namespace acunmedya_dotnetangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conditions 

            Console.WriteLine("Restaurant Menu");
            Console.WriteLine("1-Hamburger");
            Console.WriteLine("2-Pizza");
            Console.WriteLine("3-Salad");
            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Hamburger ordered");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Pizza ordered");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Salad ordered");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }


            Console.Write("Enter your role: ");
            string role = Console.ReadLine().ToLower();

            bool isAdmin = (role == "admin");
            if (isAdmin == false)
            {
                Console.WriteLine("Access denied");
            }
            else
            {
                Console.WriteLine("welcome");
            }
        }
    }
}
