using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            if (month == "May")
            {
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {nightsCount * 50 - 5.0 / 100 * nightsCount * 50:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 65:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 75:F2} lv.");
                }
                else if (nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {nightsCount * 50:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 65:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 75:F2} lv.");
                }
            }
            else if (month == "October")
            {
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {(nightsCount * 50 - 50) - 5.0 / 100 * (nightsCount * 50 - 50):F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 65:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 75:F2} lv.");
                }
                else if (nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {nightsCount * 50:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 65:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 75:F2} lv.");
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nightsCount > 7 && month == "September")
                {
                    Console.WriteLine($"Studio: {nightsCount * 60 - 60:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 72:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 82:F2} lv.");
                }
                else if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {nightsCount * 60 - 60:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 72 - 1.0 / 10 * nightsCount * 72:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 82:F2} lv.");
                }
                else if (nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {nightsCount * 60:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 72:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 82:F2} lv.");
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {nightsCount * 68:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 77:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 89 - 15.0 / 100 * nightsCount * 89:F2} lv.");
                }
                else if (nightsCount <= 14)
                {
                    Console.WriteLine($"Studio: {nightsCount * 68:F2} lv.");
                    Console.WriteLine($"Double: {nightsCount * 77:F2} lv.");
                    Console.WriteLine($"Suite: {nightsCount * 89:F2} lv.");
                }
            }
        }
    }
}