using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double grade;

            Console.WriteLine("Enter 5 grades separated by new line:");

            for (int i = 1; i <= 5; i++)
            {
                grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
            }

            double average = sum / 5;
            double roundedAverage = Math.Round(average);

            Console.WriteLine("The average is " + average + " and round off to " + roundedAverage);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}