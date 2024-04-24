namespace simple_scientifc_cal
{ 
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose Calculator Type:");
                Console.WriteLine("1. Normal Calculator");
                Console.WriteLine("2. Scientific Calculator");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        NormalCalculator();
                        break;
                    case 2:
                        ScientificCalculator();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                        break;
                }
            }
        }

        static void NormalCalculator()
        {
            Console.WriteLine("Normal Calculator");
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Enter your choice: ");

            int operation = int.Parse(Console.ReadLine());

          int result = 0;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                   if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero.");
                    break;
                default:
                    Console.WriteLine("");
                    break;
          
            }

            Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Invalid choice. Please choose 1, 2, 3, or 4.");
        }

        static void ScientificCalculator()
        {
            Console.WriteLine("Scientific Calculator");
            Console.Write("Enter a number: ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Operation:");
            Console.WriteLine("1. Exponentiation (x^y)");
            Console.WriteLine("2. Square Root (√x)");
            Console.WriteLine("3. Logarithm (log10)");
            Console.WriteLine("4. Sine (sin)");
            Console.WriteLine("5. Cosine (cos)");
            Console.WriteLine("6. Tangent (tan)");
            Console.Write("Enter your choice: ");

            Console.Write("");


            int operation = int.Parse(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case 1:
                    Console.Write("Enter the exponent: ");
                    double exponent;
                    if (!double.TryParse(Console.ReadLine(), out exponent))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    result = Math.Pow(num, exponent);
                    break;
                case 2:
                    result = Math.Sqrt(num);
                    break;
                case 3:
 
                    result = Math.Log10(num);
                    break;
                case 4:
                    result = Math.Sin(num);
                    break;
                case 5:
                    result = Math.Cos(num);
                    break;
                case 6:
                    result = Math.Tan(num);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1, 2, 3, 4, 5, or 6.");
                    return;
            }
            Console.WriteLine("");

            Console.WriteLine($"Result: {result}");
        }
    }


}
