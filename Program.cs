using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign5CS
{
    enum DayOfWeek
    {
        Saturday = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region P1 : Q1
            //Console.Write("Enter a day number (0–6): ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //if (dayNumber < 0 || dayNumber > 6)
            //{
            //    Console.WriteLine("Invalid number. Please enter a number between 0 and 6.");
            //    return;
            //}

            //DayOfWeek day = (DayOfWeek)dayNumber;
            //Console.WriteLine($"Day name: {day}");

            //switch (day)
            //{
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("It's the Weekend");
            //        break;
            //    default:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //}
            #endregion

            #region P2 : Q1 
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //int max = numbers[0];
            //int min = numbers[0];

            //for (int i = 0; i < size; i++)
            //{
            //    sum += numbers[i];

            //    if (numbers[i] > max)
            //        max = numbers[i];

            //    if (numbers[i] < min)
            //        min = numbers[i];
            //}
            //double average = (double)sum / size;

            //Console.WriteLine("\nResults:");
            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Average = " + average);
            //Console.WriteLine("Maximum = " + max);
            //Console.WriteLine("Minimum = " + min);

            //Console.WriteLine("Array in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + "  ");
            //}
            #endregion

            #region P2 : Q2 
            //int[,] grades = new int[3, 4];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");

            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //double overallSum = 0;

            //Console.WriteLine("\nStudent Averages:");

            //for (int i = 0; i < 3; i++)
            //{
            //    int studentSum = 0;

            //    for (int j = 0; j < 4; j++)
            //    {
            //        studentSum += grades[i, j];
            //    }

            //    double studentAverage = (double)studentSum / 4;
            //    Console.WriteLine($"Student {i + 1} Average = {studentAverage}");

            //    overallSum += studentSum;
            //}

            //double classAverage = overallSum / (3 * 4);

            //Console.WriteLine($"\nOverall Class Average = {classAverage}");
            #endregion

            #region P3 : Q1 
            //    Console.Write("Enter first number: ");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter operation (+, -, *, /): ");
            //    char operation = char.Parse(Console.ReadLine());

            //    double result;

            //    switch (operation)
            //    {
            //        case '+':
            //            result = Add(num1, num2);
            //            Console.WriteLine("Result = " + result);
            //            break;

            //        case '-':
            //            result = Subtract(num1, num2);
            //            Console.WriteLine("Result = " + result);
            //            break;

            //        case '*':
            //            result = Multiply(num1, num2);
            //            Console.WriteLine("Result = " + result);
            //            break;

            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Error: Cannot divide by zero.");
            //            }
            //            else
            //            {
            //                result = Divide(num1, num2);
            //                Console.WriteLine("Result = " + result);
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operation.");
            //            break;
            //    }
            //}
            //static double Add(double a, double b)
            //{
            //    return a + b;
            //}

            //static double Subtract(double a, double b)
            //{
            //    return a - b;
            //}

            //static double Multiply(double a, double b)
            //{
            //    return a * b;
            //}

            //static double Divide(double a, double b)
            //{
            //    return a / b;
            //}
            #endregion

            #region P3 : Q2 
            //    Console.Write("Enter circle radius: ");
            //    double radius = double.Parse(Console.ReadLine());

            //    double area;
            //    double circumference;

            //    CalculateCircle(radius, out area, out circumference);

            //    Console.WriteLine("Area = " + area);
            //    Console.WriteLine("Circumference = " + circumference);
            //}
            //static void CalculateCircle(double radius, out double area, out double circumference)
            //{
            //    area = Math.PI * radius * radius;
            //    circumference = 2 * Math.PI * radius;
            //}
            #endregion


        }
    }
}

