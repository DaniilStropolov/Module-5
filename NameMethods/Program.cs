namespace NameRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Евгений";
            int age = 10;
            
            Console.WriteLine(name + " " + age);
            ChangeName(ref name);
            ChangeAge(ref age);
            Console.WriteLine(name + " " + age);
        }
        static void ChangeName(ref string name)
        {
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
        }
        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
