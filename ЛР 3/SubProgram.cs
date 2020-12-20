using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_3
{
    class SubProgram : SubSubProgram
    {
        // 1 часть ЛР

        protected void Convert2To10() // Main
        {
            ulong num = ulong.MaxValue, ost = 0, result = 0, count = 0, s = 0;
            while (true)
            {
                Console.Write("Введите 2-ое число:");
                num = ulong.Parse(Console.ReadLine());
                if (num == 0) break;

                while (num > 0)
                {
                    ost = num % 10;
                    s = Convert.ToUInt64(Math.Pow(2, count));
                    result = result + ost * s;
                    count += 1;
                    num = num / 10;
                }

                Console.WriteLine($"Результат: {result} \r\n");
            }
        }

        protected void CalculateArea5() // Main
        {
            List<(double x, double y)> vertices = new List<(double, double)>
            {
                (0,2),(0,7),(0,4),(8,4),(2,8)
            };

            double a1 = Distance(vertices[0], vertices[2]);
            double b1 = Distance(vertices[0], vertices[4]);
            double c1 = Distance(vertices[2], vertices[4]);
            double area1 = CalculateAreaOfTriange(a1,b1,c1);

            double a2 = Distance(vertices[0], vertices[4]);
            double b2 = Distance(vertices[0], vertices[1]);
            double c2 = Distance(vertices[1], vertices[3]);
            double area2 = CalculateAreaOfTriange(a2, b2, c2);

            double a3 = Distance(vertices[1], vertices[4]);
            double b3 = Distance(vertices[1], vertices[3]);
            double c3 = Distance(vertices[3], vertices[4]);
            double area3 = CalculateAreaOfTriange(a3, b3, c3);

            double area = Math.Round(area1 + area2 + area3,2);
            Console.WriteLine($"Площадь: {area}");
        }

        private double CalculateAreaOfTriange(double a, double b, double c)
        {
            double halfOfPerimeter = HalfOfPerimeter(a, b, c);
            double area = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - a) * (halfOfPerimeter - b) * (halfOfPerimeter - c));
            return area;
        }

        private double HalfOfPerimeter(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        protected void CalculateFunctionWithEquations() // Main
        {
            double x1 = SolveEquation(1, -4, -1).x1;
            double y1;

            try
            {
                y1 = SolveEquation(rnd.Next(-5, 5), rnd.Next(0, 7), rnd.Next(-2, 8)).x1;
            }
            catch
            {
                y1 = SolveEquation(rnd.Next(-5, 5), rnd.Next(0, 7), rnd.Next(-2, 8)).x1;
            }

            double function = (x1 + y1) / (x1 * y1);
            Console.WriteLine($"Function = {function}");
        }

        private (double x1, double x2) SolveEquation(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) throw new Exception("Дискриминант меньше 0!");
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return (x1, x2);
        }

        protected void CalculateFuncG1() // Main
        {
            Console.Write("Введите S:");
            double S = double.Parse(Console.ReadLine());

            Console.Write("Введите T:");
            double T = double.Parse(Console.ReadLine());

            double function = G(1, Math.Sin(S)) + 2 * G(T * S, 24) - G(5, -S);
            Console.Write($"Результат: {function}");
        }

        private double G(double a, double b)
        {
            return (2 * a + Math.Pow(b, 2)) / (2 * a * b + 5 * b);
        }

        protected void PrintSpecificNumbers() 
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nЧисла, удовлетворяющие условию:");
            while (number > 0)
            {
                if (CheckNumber(number)) PrintNumber(number);
                number--;
            }
        }

        private bool CheckNumber(int number)
        {
            int startNumber = number, ost = 0;
            while (number > 0)
            {
                ost = number % 10;
                if (ost == 0 || startNumber % ost != 0) return false;
                number /= 10;
            }
            return true;
        }

        // 2 часть ЛР

        protected void CalculateFuncG2() // Main
        {
            Console.Write("Введите S:");
            double S = double.Parse(Console.ReadLine());

            Console.Write("Введите T:");
            double T = double.Parse(Console.ReadLine());

            double function = G(12, S) + G(T, S) - G(2 * S - 1, S * T);
            Console.Write($"Результат: {function}");
        }

        protected void GetMinValue() // Main
        {
            double[] values = new double[3];

            Console.WriteLine("Введите 3 любых числа:");
            for (int i = 0; i < 3; i++)
            {
                values[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Минимальное число: {FindMinValue(values)}");
        }

        private double FindMinValue(params double[] values)
        {
            double min = double.MaxValue;
            foreach (var value in values)
            {
                if (value < min) min = value;
            }
            return min;
        }

        protected void CalculateY() // Main
        {
            Console.Write("Введите S:");
            double S = double.Parse(Console.ReadLine());

            Console.Write("Введите T:");
            double T = double.Parse(Console.ReadLine());

            double function = G(12, S) + G(T, S) - G(2 * S - 1, S * T);
            Console.Write($"Результат: {function}");
        }

        protected void ConvertGramsToKilograms() // Main
        {
            Console.Write("Введите кол-во грамм: ");
            double grams = double.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {Kilograms(grams)}");
        }

        private double Kilograms(double grams)
        {
            return grams / 1000;
        }

        protected void FindSmallestCommonDivisor()
        {
            Console.WriteLine("Введите любые 4 числа: ");
            double[] numbers = new double[4];
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Наименьший общий делитель: {CommonDivisor(numbers)}");
        }

        private double CommonDivisor(params double[] numbers)
        {
            double min = FindMinValue(numbers), i;
            for (i = min; i > 0; i--)
            {
                bool reminderIsZero = true;
                for (int j = 0; j < numbers.Length; j++)
                    reminderIsZero &= numbers[j] % i == 0;
                if (reminderIsZero) break;
            }
            return i;
        }
    }
}
