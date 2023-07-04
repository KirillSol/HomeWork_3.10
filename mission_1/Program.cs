namespace mission_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше число: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"\nВаше число {userNumber} - Четное");
            }
            else
            {
                Console.WriteLine($"\nВаше число {userNumber} - Нечетное");
            }
        }
    }
}