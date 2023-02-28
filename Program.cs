namespace _28._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir = 5;

            for (int x = 0; x <= satir; x++)
            {
                for (int i = satir - x; i >= 0; i--)
                {
                    Console.Write("*");
                }

                for (int k = 1; k <= 2 * x + 1; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            
            }
    }
}