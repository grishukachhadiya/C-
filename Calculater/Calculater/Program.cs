// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System;


namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch(op)
            {
                case "1": result = num1 + num2;
                    break;
                    
                case "2": result = num1 - num2;
                    break;

                case "3": result = num1 * num2;
                    break;

                case "4": 
                    if(num2!=0) {
                        result = num1 / num2;
                    }

                    break;

                default: break;

            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("\t\t\t\t  Calculator App");
            Console.WriteLine("\t\t\t\t -----------------");

            while(!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double cleanInput1 = 0;
                double cleanInput2 = 0;
                string op = "";
                double result;


                Console.WriteLine("\n \t =>Enter First Number and Press Enter : ");
                numInput1 = Console.ReadLine();


                while(!double.TryParse(numInput1, out cleanInput1))
                {
                    Console.WriteLine("\n \t ==>Entered num is not correct please enter correct number");
                    numInput1 = Console.ReadLine();
                };

                Console.WriteLine("\n \t =>Enter Second Number and Press Enter : ");
                numInput2 = Console.ReadLine();


                while (!double.TryParse(numInput2, out cleanInput2))
                {
                    Console.WriteLine("\n \t ==>Entered num is not correct please enter correct number");
                    numInput2 = Console.ReadLine();
                };


                Console.WriteLine("\n\n  =>Choose Number for whichever operation you want to perform : ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                Console.WriteLine("Enter Number : ");

                op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanInput1, cleanInput2, op);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This is not a number");
                    }
                    else
                    {
                        Console.WriteLine("\n\n =>Answer is : " + result);
                    }

                   


                }
                catch(Exception ex)
                {
                    Console.WriteLine("Hey error is there ");
                }


                Console.WriteLine("\n for End Operation press 5 or press any other key to continue :");
                if(Console.ReadLine()=="5")
                {
                    endApp = true;
                }
            }
        }
    }
}