

namespace ConsoleApp31
{
    internal class Task1
    {
        public void Task(int size, char s)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
