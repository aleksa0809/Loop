using System;

namespace myapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (true)
            {
                count*=2;
                for (int i = 0; i < count; i++)
                {
                    Console.Write("next? ");
               
                }
                     Console.WriteLine();
                string answer = Console.ReadLine();
                if (answer == "Q")
                {
                    break;
                }

            }

        }
    }
}
