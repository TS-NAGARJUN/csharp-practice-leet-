using System;
using csharp.SortAlgorithms;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Size (or -1 to exit): ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n < -1)
                {
                    Console.WriteLine("Bad size. Try again.");
                    continue;
                }
                if (n == -1) break;

                Console.WriteLine("Enter the elements (space-separated):");
                var parts = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < n)
                {
                    Console.WriteLine("Not enough numbers. Try again.");
                    continue;
                }

                int[] array = new int[n];
                for (int i = 0; i < n; i++) array[i] = int.Parse(parts[i]);

                Console.Write("Choose 1=Quick 2=Bubble 3=Selection (or -1 to exit): ");
                string choiceLine = Console.ReadLine() ?? "";
                if (!int.TryParse(choiceLine.Trim(), out int choice))
                {
                    Console.WriteLine("Invalid choice, defaulting to QuickSort.");
                    choice = 1;
                }
                if (choice == -1) break;

                switch (choice)
                {
                    case 1:
                        QuickSorting.QuickSort(array);
                        break;
                    case 2:
                        BubbleSort.Sort(array);
                        break;
                    case 3:
                        SelectionSort.Selection(array);
                        break;
                    default:
                        Console.WriteLine("Invalid choice, using QuickSort.");
                        QuickSorting.QuickSort(array);
                        break;
                }

                Console.WriteLine("Sorted: " + string.Join(", ", array));
                Console.WriteLine();
            }
        }
    }
}