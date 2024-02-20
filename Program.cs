using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static int num1 = 0;
        static int num2 = 0;

        static string oper = "+";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Value");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Operator");
            oper = Console.ReadLine() ?? "";
            Console.WriteLine("Enter The Second Value");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number1:{num1}, Operator:{oper},Number2:{num2}");

            Console.WriteLine($"{num1}{oper}{num2}=",Calculate(num1,num2,oper));
            Console.ReadKey();
            
        }

        static int Calculate(int num1,int num2,string oprtor)
        {
            switch (oprtor)
            {
                case "+":
                    return Add(num1,num2);
                case "-":
                    return Subtract(num1,num2);
                case "*":
                    return Multiply(num1,num2);
                case "/":
                    return Devide(num1,num2);
                default:
                   Console.WriteLine("Invalid Operator");
                   return 0;
            }
        }

        static int Add(int n1,int n2)
        {
            return n1 + n2;
        }
        static int Subtract(int n1,int n2)
        {
            return n1 - n2;
        }
        static int Multiply(int n1,int n2)
        {
            return n1 * n2;
        }
        static int Devide(int n1,int n2)
        {
            return n1 / n2;
        }
    }
}