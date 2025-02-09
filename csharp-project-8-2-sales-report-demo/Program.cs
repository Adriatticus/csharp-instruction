using System.Diagnostics.CodeAnalysis;

namespace csharp_project_8_2_sales_report_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Can you come in on saturday and finish the sales report?");

            decimal[,] sales = { {1540.0m, 2010.0m, 2450.0m, 1845.0m},
                                {1130.0m, 1168.0m, 1847.0m, 1491.0m},
                                {1580.0m, 2305.0m, 2710.0m, 1284.0m},
                                {1105.0m, 4102.0m, 2391.0m, 1576.0m}};

            decimal sum = 0.0m;


            // 1) Dump data to console by region (rows), quarter (columns)
            Console.WriteLine("Region  Q1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write((i + 1) + "\t");

                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write(sales[i, j].ToString("c") + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            // 2) Sum Sales by region (regions 1, 2, 3, and 4)

            Console.WriteLine("Sales by region:");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                sum = 0.0m;
                Console.Write((i + 1) + ": ");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                }
                Console.WriteLine(sum.ToString());
            }
            // 3) Sum Sales by quarter (q1, q2, q3, q4)

            Console.WriteLine("\nSales by quarter:");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write(("Q" + (i + 1) + ": "));
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[j, i];
                }
                Console.WriteLine(sum.ToString("c"));
            }
            // 4) Total sales (sum of all data)

            decimal total = 0.0m;
            for (int i = 0; i < sales.GetLength(1); i++)
            {
                for (int j = 0; j < sales.GetLength(0); j++)
                {
                    total += sales[i, j];
                }
            }
            Console.WriteLine("\nTotal sales: " + total.ToString("c"));
        }

    }
}
