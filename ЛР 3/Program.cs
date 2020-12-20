using System;

namespace ЛР_3
{
    class Program : SubProgram
    {
        private static bool isRunning = true;

        static void Main(string[] args)
        {
            Program behaviour = new Program();

            do {
                Console.Write("Введите номер задания(1-20):");
                int numberOfTask = int.Parse(Console.ReadLine());
                behaviour.Behave(numberOfTask);

                Console.Write("Хотите прервать работу программы?(Yes/No):");
                isRunning = Console.ReadLine().ToLower() == "YES" ? false : true;
                Console.WriteLine();
            } while (isRunning);

            Console.ReadKey();
        }

        private void Behave(int numberOfTask)
        {
            switch (numberOfTask)
            {
                case 1:
                    CalculatePerimeter10();
                    break;
                case 2:
                    PrintThreeNumbers();
                    break;
                case 3:
                    CalculateFunction();
                    break;
                case 4:
                    CalculatePerimeter6();
                    break;
                case 5:
                    Pow();
                    break;
                case 6:
                    Convert2To10();
                    break;
                case 7:
                    CalculateArea5();
                    break;
                case 8:
                    CalculateFunctionWithEquations();
                    break;
                case 9:
                    CalculateFuncG1();
                    break;
                case 10:
                    PrintSpecificNumbers();
                    break;
                case 11:
                    CalculateLeg();
                    break;
                case 12:
                    CalculateSum();
                    break;
                case 13:
                    AverageOfArrays();
                    break;
                case 14:
                    CalculatePFunctions();
                    break;
                case 15:
                    DetermineDegree2();
                    break;
                case 16:
                    CalculateFuncG2();
                    break;
                case 17:
                    GetMinValue();
                    break;
                case 18:
                    CalculateY();
                    break;
                case 19:
                    ConvertGramsToKilograms();
                    break;
                case 20:
                    FindSmallestCommonDivisor();
                    break;
            }
        }
    }
}
