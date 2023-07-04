namespace mission_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");
            int sequence = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите 1 число: ");
            int MaxValue = int.Parse(Console.ReadLine());


            int value;
            for (int i = 2; i <= sequence; i++)
            {
                Console.WriteLine($"\nВведите {i} - число");
                value = int.Parse(Console.ReadLine());

                if (value > MaxValue)
                {
                    continue;
                }
                else
                {
                    MaxValue = value;

                }
            }
            Console.WriteLine($"\nМинимальное число: {MaxValue}");

        }
    }
}