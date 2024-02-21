using System;

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


            Calculate(num1,num2,oper);
            Console.ReadKey();
            
        }

        static void Calculate(int num1, int num2, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine($"{num1} {oper} {num2} = {Add(num1, num2)}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} {oper} {num2} = {Subtract(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} {oper} {num2} = {Multiply(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} {oper} {num2} = {Devide(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
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