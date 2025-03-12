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

            int[] sortedArrayAsc;
            int[] sortedArrayDesc;

            SortArray(numbers, out sortedArrayAsc, out sortedArrayDesc);

            Console.WriteLine("Массив, отсортированный по возрастанию: ");
            foreach (int num in sortedArrayAsc)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Массив, отсортированный по убыванию: ");
            foreach (int num in sortedArrayDesc)
            {
                Console.WriteLine(num);
            }
        }
        static void SortArray(int[] numbers, out int[] sortedArrayAsc, out int[] sortedArrayDesc)
        {
            sortedArrayAsc = (int[])numbers.Clone();
            sortedArrayDesc = (int[])numbers.Clone();
            SortArrayAsc(sortedArrayAsc);
            SortArrayDesc(sortedArrayDesc);
        }
        static void SortArrayDesc(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
        static void SortArrayAsc(int[] numbers)
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
        }
    }
}