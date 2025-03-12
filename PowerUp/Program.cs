namespace PowerUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            byte pow = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(PowerUp(N, pow));
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
            }
        }
    }
