namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите количество элементов в массиве: ");
            
            int[] myArray = GetArrayFromConsole(Convert.ToInt32(Console.ReadLine()));
            SortArray(myArray);
            Console.WriteLine("");
            foreach (var value in myArray)
            {
                Console.WriteLine(value);
            }
        }
        static int[] GetArrayFromConsole(int valuesNumber)
        {
            int[] values = new int[valuesNumber];
            for (int i = 0; i < valuesNumber; i++)
            {
                Console.WriteLine($"Введите значение массива №{i}: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            return values;
        }
        static int[] SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

    }
}
