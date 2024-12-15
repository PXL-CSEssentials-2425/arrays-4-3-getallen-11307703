using System.Globalization;

namespace _3Getallen
{
    internal class Program
    {
        private static int[] numbers = new int[3];
        static void Main(string[] args)
        {
            Console.WriteLine("==Som bepalen van 3 getallen==");
            Console.WriteLine();
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Geef getal {i+1}/3 : ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.Write($"De som is {sum}");
            Console.ReadKey(true);


        }
    }
}
