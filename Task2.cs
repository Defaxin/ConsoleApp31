
namespace ConsoleApp31
{
    internal class Task2
    {
        public void Task(int number)
        {
            int revers = 0;
            int num = number;
            while (number > 0)
            {
                int d = number % 10;
                revers = revers * 10 + d;
                number /= 10;
            }
            if (num == revers)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
