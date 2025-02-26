namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TakeNumberForSum();
            // WhileLoopExample();

        }


        // 
        static void WhileLoopExample()
        {
            int controller = 0;
            while (controller == 0)
            {
                Console.Write("Enter a number between 10 and 100: ");
                int number02 = int.Parse(Console.ReadLine());

                if (number02 > 10 & number02 < 100)
                {
                    Console.WriteLine("Your number is: " + number02);
                    controller = 1;
                }
                else
                {
                    Console.WriteLine("Try again. Your number is wrong");
                }

            }
        }


        // algorithm for summing the digits of a number
        static void TakeNumberForSum()
        {
            Console.Write("Enter a number: ");
            int number01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + TotalNumbers(number01));
        }
        static int TotalNumbers(int i)
        {
            if (i < 10)
            {
                return i;
            }
            else
            {
                return (i % 10) + TotalNumbers(i / 10);
            }
        }

    }
}
