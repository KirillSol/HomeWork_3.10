namespace mission_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int userNumber = int.Parse(Console.ReadLine());

            bool numSimple = true;
            int i = 2;
            while (i < userNumber)
            {
                if (userNumber % i == 0)
                {
                    numSimple = false;
                    break;
                }

                i++;
            }
            if (numSimple)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
        }
    }
}