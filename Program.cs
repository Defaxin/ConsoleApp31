using System;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 ts1 = new Task1();
            Task2 ts2 = new Task2();
            Task3 ts3 = new Task3();
            WebSite ws = new WebSite();
            Magazine mg = new Magazine();
            Shop sp = new Shop();
            int[] first = { 1, 2, 3, 4, 5, 6, 7 };
            int[] second = { 2, 4, 6 };
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-6 or 7 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine("Task1: ");
                        ts1.Task(4, '*');
                        break;
                    case 2:
                        Console.WriteLine("Task2: ");
                        ts2.Task(1441);
                        ts2.Task(1234);
                        break;
                    case 3:
                        Console.WriteLine("Task3: ");
                        ts3.Task(first, second);
                        break;
                    case 4:
                        Console.WriteLine("Task4: ");
                        ws.InputData();
                        ws.Show();
                        break;
                    case 5:
                        Console.WriteLine("Task5: ");
                        mg.InputData();
                        mg.Show();
                        break;
                    case 6:
                        Console.WriteLine("Task6: ");
                        sp.InputData();
                        sp.Show();
                        break;
                    case 7:
                        whil = 1;
                        break;
                }
            }
        }
    }
}
