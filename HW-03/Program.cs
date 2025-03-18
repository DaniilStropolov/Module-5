namespace HW_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            displayUserInfo(enterUser());
        }
        static (string firstName, string lastName, int age, string[] petNames, string[] favColors) enterUser()
        {
            (string firstName, string lastName, int age, string[] petNames, string[] favColors) User;
            User.firstName = getValidString("Введите имя: ");
            User.lastName = getValidString("Введите фамилию: ");
            User.age = getValidInt("Введите возраст: ");
            string hasPets = getValidString("Есть ли у вас питомцы (да/нет): ");
            User.petNames = null;
            while (true)
            {
                if (hasPets == "да" || hasPets == "Да" || hasPets == "нет" || hasPets == "Нет")
                {
                    break;
                }
                else
                {
                    hasPets = getValidString("Есть ли у вас питомцы (да/нет): ");
                }
            }
            if (hasPets == "да" || hasPets == "Да")
            {
                int petsCount = getValidInt("А сколько у вас питомцев?: ");
                User.petNames = new string[petsCount];
                for (int i = 0; i < petsCount; i++)
                {
                    User.petNames[i] = getValidString($"Назовите питомца №{i + 1}: ");
                }
            }

            int colorCount = getValidInt("Введите количество ваших любимых цветов: ");
            User.favColors = new string[colorCount];
            for (int i = 0; i < colorCount; i++)
            {
                User.favColors[i] = getValidString($"Назовите цвет №{i + 1}: ");
            }
            return User;
        }
        static string getValidString(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                string value = Console.ReadLine();
                if (string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("Вы вводите пустое значение. Попробуйте еще раз.");
                    Console.Write(prompt);
                    continue;
                }
                if (int.TryParse(value, out _))
                {
                    Console.WriteLine("Вы вводите число. Попробуйте еще раз.");
                    Console.Write(prompt);
                    continue;
                }
                return value;
            }
        }
        static int getValidInt(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть положительным. Попробуйте еще раз.");
                        Console.Write(prompt);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число.");
                    Console.Write(prompt);
                    continue;
                }
            }
        }
        static void displayUserInfo((string firstName, string lastName, int age, string[] petNames, string[] favColors) User)
        {
            Console.WriteLine("\n\n\nДанные пользователя:");
            Console.WriteLine($"Имя: {User.firstName}");
            Console.WriteLine($"Фамилия: {User.lastName}");
            Console.WriteLine($"Возраст: {User.age}");
            if (User.petNames == null)
            {
                Console.WriteLine("Животные отсутствуют");
            }
            else
            {
                Console.WriteLine($"Количество домашних животных: {User.petNames.Length}");
                foreach (string pet in User.petNames)
                {
                    Console.WriteLine("   " + pet);
                }
            }
            Console.WriteLine($"Любимых цветов: {User.favColors.Length}");
            foreach (string color in User.favColors)
            {
                Console.WriteLine("   " + color);
            }
        }
    }
}