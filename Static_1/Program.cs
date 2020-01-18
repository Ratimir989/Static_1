using System;

namespace Static_1
{
    static class Calculator
    {
        public static double Add(double i, double j)
        {
            return i + j;
        }

        public static double Sub(double i, double j)
        {
            return i - j;
        }

        public static double Div(double i, double j)
        {
            return i / j;
        }

        public static double Mul(double i, double j)
        {
            return i * j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Введите операцию (+-/*):");
            string op = Console.ReadLine();
            double result = 0;
            switch (op)
            {
                case "+":
                    Operation(op, ref result);
                    Console.WriteLine("Результат операции = " + result);
                    Menu();
                    break;
                case "-":
                    Operation(op, ref result);
                    Console.WriteLine("Результат операции = " + result);
                    Menu();
                    break;
                case "/":
                    Operation(op, ref result);
                    Console.WriteLine("Результат операции = " + result);
                    Menu();
                    break;
                case "*":
                    Operation(op, ref result);
                    Console.WriteLine("Результат операции = " + result);
                    Menu();
                    break;
                default:
                    Console.WriteLine("Введите корректный символ!");
                    Menu();
                    break;
            }
        }

        public static void Operation(string op, ref double result)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double firstN = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double secondN = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = Calculator.Add(firstN, secondN);
                        break;
                    case "-":
                        result = Calculator.Sub(firstN, secondN);
                        break;
                    case "/":
                        result = Calculator.Div(firstN, secondN);
                        break;
                    case "*":
                        result = Calculator.Mul(firstN, secondN);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Введите число корректно!");
                Operation(op, ref result);
            }
        }
    }

}

