namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {
                string[] choosen = { "H", "T" };
                string pick;
                string yorn;
                Random rnd = new Random();
                int num = rnd.Next(1, 3);
                int num2 = 0;

                Console.WriteLine("Heads or Tails?");
                Console.WriteLine("Type H or T: ");
                pick = Console.ReadLine();

                if (pick.ToUpper() == choosen[0])
                {
                    num2 = 1;
                }
                else if (pick.ToUpper() == choosen[1])
                {
                    num2 = 2;
                }
                if (num == 1)
                {
                    Console.WriteLine("It was heads!");
                }
                else if (num == 2)
                {
                    Console.WriteLine("It was tails!");
                }
                if (num == num2)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost!");
                }
                Console.WriteLine("Do you want to try again?");
                Console.WriteLine("Type Y or any key to quit: ");
                yorn = Console.ReadLine();
                if (yorn.ToUpper() == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }


        }
    }
}
