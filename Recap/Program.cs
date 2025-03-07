using System.Net.WebSockets;

namespace Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = (name: "", dishes: new string[5]);
            Console.WriteLine("Как тебя зовут?");
            user.name = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Напишите свое любимое блюдо №{i + 1}");
                user.dishes[i] = Console.ReadLine();
            }
        }
    }
}
