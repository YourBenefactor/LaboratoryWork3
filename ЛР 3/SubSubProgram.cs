using System;
using System.Collections.Generic;
using System.Linq;

namespace ЛР_3
{
    class SubSubProgram
    {
        protected Random rnd = new Random();

        // 1 часть ЛР

        protected void CalculatePerimeter6() // Main
        {
            List<(double x, double y)> vertices = new List<(double, double)>
            {
                (3, 1), (5,1), (6,7), (3,7), (2,5), (2, 3)
            };

            double perimeter = 0;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (i != vertices.Count - 1)
                {
                    perimeter += Distance(vertices[i], vertices[i + 1]);
                }
                else perimeter += Distance(vertices[i], vertices[0]);
            }

            Console.WriteLine(perimeter);
        } 

        protected void CalculatePerimeter10() // Main
        {
            List<(double x, double y)> vertices = new List<(double, double)>
            {
                (3, 1), (5,1), (7,2), (7,3), (6,3), (6,4), 
                (7,5), (7,6), (6,7), (3,7), (2,5), (2, 3)
            };

            double perimeter = 0;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (i != vertices.Count - 1) {
                    perimeter += Distance(vertices[i], vertices[i + 1]);
                }
                else perimeter += Distance(vertices[i], vertices[0]);
            }

            Console.WriteLine(perimeter);
        }

        protected double Distance((double, double) start, (double, double) end)
        {
            return Math.Sqrt(Math.Pow(start.Item1 - end.Item1, 2) + Math.Pow(start.Item2 - end.Item2, 2));
        }

        protected void PrintThreeNumbers() // Main
        {
            List<double> numbers = new List<double>(3);
            while (numbers.Count != 3)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    numbers.Add(number);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Были введены следующие числа:");

            foreach (var num in numbers)
            {
                PrintNumber(num);
            }
        }

        protected void PrintNumber(double number)
        {
            foreach (var sign in number.ToString())
            {
                Console.Write(sign);
            }
            Console.WriteLine();
        }

        protected void CalculateFunction() // Main
        {
            Console.Write("Введите S:");
            double S = double.Parse(Console.ReadLine());

            Console.Write("Введите T:");
            double T = double.Parse(Console.ReadLine());

            double function = F(T, -2 * S, 1.17) + F(2.2, T, S - T);
            Console.Write($"Результат: {function}");
        }

        private double F(double A, double B, double C)
        {
            return (2 * A - B - Math.Sin(C)) / (5 + C);
        }

        protected void Pow() // Main
        {
            double number = double.NegativeInfinity;
            while (number != 0)
            {
                Console.Write("Введите число: ");
                double.TryParse(Console.ReadLine(), out number);

                Console.Write("Введите степень: ");
                int degree = int.Parse(Console.ReadLine());

                Console.WriteLine($"Число {number} в степени {degree}: {Math.Pow(number, degree)}");
            }
        }

        // 2 часть ЛР

        protected void CalculateLeg() // Main
        {
            double a = rnd.Next(1, 10);
            double c = rnd.Next(1, 10);
            double b = Math.Round(CalculateLegMethod(a, c), 2);
            Console.WriteLine($"Треугольник: a = {a}; b = {b}; c = {c}");
        }

        private double CalculateLegMethod(double a, double c)
        {
            return Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
        }

        protected void CalculateSum() 
        {
            List<double> array = GenerateNewArray(10);
            int printCount = rnd.Next(2, array.Count);
            double sum = SumOfRange(array, printCount);
            Console.Write($"\r\nСумма первых {printCount} элементов массива: {sum}");
        }

        private List<double> GenerateNewArray(int n)
        {
            List<double> newArray = new List<double>(n);
            Console.Write("Array: ");
            for (int i = 0; i < n; i++)
            {
                newArray.Add(rnd.Next(-10, 40));
                Console.Write(newArray[i] + " ");
            }
            return newArray;
        }

        private double SumOfRange(List<double> array, int count)
        {
            double result = 0;
            for (int i = 0; i < count; i++)
            {
                result += array[i];
            }
            return result;
        }

        protected void AverageOfArrays() // Main
        {
            List<double> first = GenerateNewArray(10);
            Console.WriteLine($"\r\nСреднее арифметическое: {first.Average()}");

            List<double> second = GenerateNewArray(10);
            Console.WriteLine($"\r\nСреднее арифметическое: {second.Average()}");
        }

        protected void CalculatePFunctions() // Main
        {
            Console.Write("Введите конечное число: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\nЗначения функций:");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Значение функции P при x = {i}: {P(i)}");
            }
        }

        private double P(int x)
        {
            return 10 * Math.Pow(x, 3) - 14 * Math.Pow(x, 2) + 12 * x - 2;
        }

        protected void DetermineDegree2() // Main
        {
            Console.Write("Введите число, являющееся степенью 2:");
            int number = int.Parse(Console.ReadLine());
            int degree = CheckDegree2(number);
            if (degree == int.MaxValue) Console.WriteLine("Число не являлось степенью 2");
            else Console.WriteLine($"Степень: {degree}");
        }

        private int CheckDegree2(int number)
        {
            int degree = 0;
            while (number >= 2)
            {
                int ost = number % 2;
                if (ost != 0) return int.MaxValue;
                number /= 2;
                degree++;
            }
            return degree;
        }
    }
}
