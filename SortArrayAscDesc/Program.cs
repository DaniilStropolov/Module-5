namespace SortArrayAscDesc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 2, 7, 9, 3, 6, 5, 22, -2 };
            Console.WriteLine("Первоначальный массив: ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Отсортированный по возрастанию массив: ");
            SortArrayAsc(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Отсортированный по убыванию массив: ");
            SortArrayDesc(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        static int[] SortArrayDesc(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length; i ++)
            {
                for (int j = 0; j < numbers.Length; j ++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
        static int[] SortArrayAsc(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
