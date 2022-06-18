using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodexcercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Are we going to add, subtract, multiply, or divide?");
            string input;
            
            var add = "add";
            var subtract = "subtract";
            var multiply = "multiply";
            var divide = "divide";
            input = Console.ReadLine();
            int sum;

            if (input == "add")
            {
                Console.Write("enter first value: ");
                int in1 = int.Parse(Console.ReadLine());
                Console.Write("enter second value: ");
                int in2 = int.Parse(Console.ReadLine());


                int total1 = Add(in1, in2);

                Console.WriteLine(total1);
                Console.ReadLine();
            }
            else if (input == "subtract")
            {
                Console.Write("enter first value: ");
                int in1 = int.Parse(Console.ReadLine());
                Console.Write("enter second value: ");
                int in2 = int.Parse(Console.ReadLine());


                int total1 = Subtract(in1, in2);

                Console.WriteLine(total1);
                Console.ReadLine();
            }
            else if (input == "multiply")
            {
                Console.Write("enter first value: ");
                int in1 = int.Parse(Console.ReadLine());
                Console.Write("enter second value: ");
                int in2 = int.Parse(Console.ReadLine());


                int total1 = Multiply(in1, in2);

                Console.WriteLine(total1);
                Console.ReadLine();
            }
            else if (input == "divide")
            {
                Console.Write("enter first value: ");
                double in1 = double.Parse(Console.ReadLine());
                Console.Write("enter second value: ");
                double in2 = double.Parse(Console.ReadLine());


                double total1 = Divide(in1, in2);

                Console.WriteLine(total1);
                Console.ReadLine();
            }
            else 
            {  
                Console.WriteLine("Invalid entry. run program again.");
                Console.ReadLine();
            }
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum; 
        }
        public static int Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        public static int Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
        public static double Divide(double num1, double num2)
        {
            double sum = num1 / num2;
            return sum;
        }
    }

}
