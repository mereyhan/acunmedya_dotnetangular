namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CheckPositiveNegative();
            // CheckDay();
            // BasicCalculator();
            // FindBigNumber();
            // CheckPassword();
        }

        static void CheckPositiveNegative()
        {
            Console.Write("Pozitif veya negatiflik durumunu ogrenmek istediginiz tam sayi: ");
            string tempVariable = Console.ReadLine();
            int unknownNumber; // Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(tempVariable, out unknownNumber))
            {
                if (unknownNumber < 0)
                {
                    Console.WriteLine(unknownNumber + " " + " bir negatif sayi");
                }
                else if (unknownNumber > 0)
                {
                    Console.WriteLine(unknownNumber + " " + " bir pozitif sayi");
                }
                else
                {
                    Console.WriteLine(unknownNumber + " " + " bir notr sayi");
                }
            }
            else
            {
                Console.WriteLine("Tebrikler dusunulmemis bir ihtimal buldunuz... mu?");
            }
        }

        static void CheckDay()
        {
            Console.WriteLine("which day of the week to show? (1 ... 7)");
            int selectedDay = Convert.ToInt32(Console.ReadLine());

            switch (selectedDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Try choosing one of 7 days");
                    break;
            }
        }

        static void BasicCalculator()
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select an operation(+, -, *, /): ");
            Char operation1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            double operationResult;

            if (operation1 == '-')
            {
                operationResult = number1 - number2;
                Console.WriteLine("=" + operationResult);
            }
            else if (operation1 == '+')
            {
                operationResult = number1 + number2;
                Console.WriteLine("=" + operationResult);
            }
            else if (operation1 == '*')
            {
                operationResult = number1 * number2;
                Console.WriteLine("=" + operationResult);
            }
            else if (operation1 == '/')
            {
                if (number1 == 0 && number2 == 0)
                {
                    Console.WriteLine("Error");
                }
                else if (number2 == 0)
                {
                    Console.WriteLine("Infinity");
                }
                else
                {
                    operationResult = number1 / number2;
                    Console.WriteLine("=" + operationResult);
                }
            }
            else
            {
                Console.WriteLine("Trust me. It is calculated");
            }
        }

        static void FindBigNumber()
        {
            Console.WriteLine("Enter the numbers to sort");
            Console.Write("Enter integer  #1: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer  #2: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer  #3: ");
            int int3 = Convert.ToInt32(Console.ReadLine());

            if (int1 < int2 && int1 < int3)
            {
                if (int2 < int3)
                {
                    Console.WriteLine("sorted numbers:\n" + int1 + "<" + int2 + "<" + int3);
                }
                if (int3 < int2)
                {
                    Console.WriteLine("sorted numbers:\n" + int1 + "<" + int3 + "<" + int2);
                }
            }
            else if (int2 < int1 && int2 < int3)
            {
                if (int1 < int3)
                {
                    Console.WriteLine("sorted numbers:\n" + int2 + "<" + int1 + "<" + int3);
                }
                if (int3 < int1)
                {
                    Console.WriteLine("sorted numbers:\n" + int2 + "<" + int3 + "<" + int1);
                }
            }
            else
            {
                if (int2 < int3)
                {
                    Console.WriteLine("sorted numbers:\n" + int3 + "<" + int2 + "<" + int1);
                }
                if (int3 < int2)
                {
                    Console.WriteLine("sorted numbers:\n" + int3 + "<" + int1 + "<" + int2);
                }
            }
        }

        static void CheckPassword()
        {
            Console.WriteLine("How secure is your password?");
            string passwordString = Console.ReadLine();
            char[] userPassword = passwordString.ToCharArray();

            bool checkSpecialChar = false;
            bool checkUpperCase = false;
            bool checkpassword = true;

            foreach (char i in passwordString)
            {
                if (!char.IsLetterOrDigit(i))
                {
                    checkSpecialChar = true;
                    break;
                }
            }

            foreach (char i in passwordString)
            {
                if (char.IsUpper(i))
                {
                    checkUpperCase = true;
                    break;
                }
            }

            if (checkSpecialChar == false)
            {
                Console.WriteLine("Your password must contain at least one special character.");
                checkpassword = false;
            }
            if (checkUpperCase == false)
            {
                Console.WriteLine("Your password must contain at least one capital letter.");
                checkpassword = false;
            }
            if (userPassword.Length < 8)
            {
                Console.WriteLine("Your password is too short. It should be at least 8 characters.");
                checkpassword = false;
            }
            if (checkpassword == true)
            {
                Console.WriteLine("I think your password is fine.");
            }
        }

    }
}