using System;

namespace CharlieSimpleCalculator
{
    public class Program

    {   // Operations  to be carried out.
        public static double Operate(double a, double b, char op)
        {
            double Result = double.NaN;

            if (op == '+')
            {
                Console.WriteLine($"{nameof(Result)} = " + (a + b));
            }
            else if (op == '-')
            {
                Console.WriteLine($"{nameof(Result)} = " + (a - b));
            }
            else if (op == '*')
            {
                Console.WriteLine($"{nameof(Result)} = " + (a * b));
            }
            else if (op == '/')
            {
                while (b == 0)// Validating divisor.
                {
                    Console.WriteLine("Please enter a non zero divider");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"{nameof(Result)} = " + (a / b));
            }
            Console.ReadKey();
            return Result;
        }


        static void Main(string[] args)
        {
            bool endApp = false;
            //Display title
            Console.WriteLine("CHARLIE SIMPLE CALCULATOR\n");
            while (!endApp)
            {
                // Declare variable and set to empty
                string a = "";
                string b = "";
                double result = 0;

                Console.Write("Please Input your first Number: ");
                a = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(a, out cleanNum1))
                {
                    Console.Write(" PLEASE ENTER A VALID NUMBER: ");
                    a = Console.ReadLine();

                }

                Console.Write("Please Input your second Number: ");
                b = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(b, out cleanNum2))
                {
                    Console.Write("PLEASE ENTER A VALID NUMBER:");
                    b = Console.ReadLine();
                }


                Console.Write("Please Select your prefered operation\n" +
                    "\n+ for addition" +
                    " \n- for subtraction" +
                    " \n* for multiplication" +
                    "\n/ for Division: ");

                char op = Convert.ToChar(Console.ReadLine());
                try
                {
                    result = Program.Operate(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will run to error");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("an exception error has occured");
                }

                Console.WriteLine("..................\n");


                //Wait for the user to respond before closing.
                Console.WriteLine("press 'n' and Enter key to close the app or" +
                                  " press any other key and Enter Key to continue");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");


            }
            return;
        }
    }

}