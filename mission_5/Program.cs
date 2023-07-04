namespace mission_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nИгра \"Угадай-ка\"");
            Console.WriteLine("Укажите диапазон. До скольки загадывать?");
            int N = int.Parse(Console.ReadLine());

            Random random = new Random();

            int iiNumber = random.Next(1, N + 1);

            while (true) 
            {
                Console.WriteLine("\nВведите число: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"Уже сдался? Загаданное число {iiNumber}");
                    break;
                }

                if (int.TryParse(input, out int userNumber))
                {
                    if (userNumber > iiNumber)
                    {
                        Console.WriteLine("Введено число больше загаданного. Попробуйте еще раз");
                    }
                    else if (userNumber < iiNumber)
                    {
                        Console.WriteLine("Введено число меньше загаданного. Попробуйте еще раз");
                    }
                    else
                    {
                        Console.WriteLine($"Поздравляю, число угадано!");
                        break;
                    }
                }

                

            }
        }
    }
}