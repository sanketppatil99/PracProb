namespace FlipCoin
{
    class Progam
    {
        public static void Main(string[] args)
        {
            {
               // int Head = 0;
               // int Tail = 0;
                int HeadCount = 0;
                int TailCount = 0;

                double HeadPercentage;
                double TailPercentage;

                Console.WriteLine("Enter the number of flipcoin =  ");

                int FlipCoin = Convert.ToInt32(Console.ReadLine());

                if (FlipCoin > 0)
                {
                    for (int i = 0; i < FlipCoin; i++)
                    {
                        Random random = new Random();
                        int number = random.Next(2);
                        Console.WriteLine("The number generated =  " + number);
                        if (number == 0)
                        {
                            TailCount++;
                        }
                        else
                        {
                            HeadCount++;
                        }
                        Console.WriteLine("The count of Head is " + HeadCount);
                        Console.WriteLine("The count of Tail is " + TailCount);

                        HeadPercentage = HeadCount * 100 / FlipCoin;
                        TailPercentage = TailCount * 100 / FlipCoin;

                        Console.WriteLine("The percentage of Head is {0}% ", HeadPercentage);
                        Console.WriteLine("The percentage of Tail is {0}%", TailPercentage);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter positive and greter than zero ");
                }
            }
        }
    }
}
