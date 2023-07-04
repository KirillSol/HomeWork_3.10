namespace mission_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Я решил сделать игру по настоящим правилам "21" взяв их из интернета 


            Console.WriteLine("Добро пожаловать в карточную игру - 21 !\n");
            Console.Write("Сколько карт у вас в руке? ");

            int numberOfCards = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 1; i <= numberOfCards; i++)
            {
                Console.WriteLine("Введите номинал каждой карты. Для карт с числовым номиналом вводите только цифру." +
                    " \r\nДля «картинок» следует принять обозначения латинскими буквами:" +
                    " \r\nВалет = J" +
                    " \r\nДама = Q" +
                    " \r\nКороль = K" +
                    " \r\nТуз = T");

                Console.Write($"\nНоминал вашей {i} карты: ");
                string card = Console.ReadLine();

                int cardValue = 0;
                switch (card)
                {
                    case "J":
                        cardValue = 2;
                        break;
                    case "Q":
                        cardValue = 3;
                        break;
                    case "K":
                        cardValue = 4;
                        break;
                    case "T":
                        cardValue = 11;
                        break;
                    case "6":
                        cardValue = 6;
                        break;
                    case "7":
                        cardValue = 7;
                        break;
                    case "8":
                        cardValue = 8;
                        break;
                    case "9":
                        cardValue = 9;
                        break;
                    case "10":
                        cardValue = 10;
                        break;
                    default:
                        Console.WriteLine("Карты с таким номеналом не существует!"); ; 
                        break;
                }
                totalSum += cardValue;

            }

            Console.WriteLine($"\nСумма карт в вашей руке равна: {totalSum}");
        }
    }
}