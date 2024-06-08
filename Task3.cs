namespace ConsoleApp31
{
    internal class Task3
    {
        public void Task(int[] origarr, int[] arr)
        {
            for (int i = 0; i < origarr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (origarr[i] == arr[j])
                    {
                        origarr[i] = 0;
                    }
                }
            }
            foreach (int i in origarr)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
