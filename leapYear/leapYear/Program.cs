namespace leapYear
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 400;
            int b = 100;
            int c = 4;
            Console.WriteLine("Enter the year in Four digit =  ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if ((userInput % a) == 0)
            {
                Console.WriteLine(" {0} is Leap Year ", userInput);
            }
            else if ((userInput % b) == 0)
            {
                Console.WriteLine(" {0} is not a leap year ", userInput);
            }
            else if ((userInput % c) == 0)
            {
                Console.WriteLine("{0} is leap Year ", userInput);
            }
            else
            {
                Console.WriteLine("{0} is not a leap Year", userInput);
            }
        }
    }
}
