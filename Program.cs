namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 20);

            Console.WriteLine("Welcome to the Numbers Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 20.");
            Console.WriteLine("Can you guess what it is? \nYou have 5 attempts!");

            mainGame(number);

        }

        static void mainGame(int number)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your guess: ");
                try
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if(guess == number)
                    {
                        Console.WriteLine("Congratulations! You guessed the number!");
                        break;
                    }
                    else if( guess < 1 || guess > 20)
                    {
                        Console.WriteLine("Please enter a number between 1 and 20.");
                        i--;
                    }
                    else if (guess < number)
                    {
                        if(i == 4)
                        {
                            Console.WriteLine("Sorry, you've used all your attempts. The number was " + number);
                        }
                        else
                        {
                            Console.WriteLine("Too low! Try again.");
                        }
                    }
                    else if (guess > number)
                    {
                        if(i == 4)
                        {
                            Console.WriteLine("Sorry, you've used all your attempts. The number was " + number);
                        }
                        else
                        {
                            Console.WriteLine("Too high! Try again.");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--;
                    continue;
                }
            }
        }
    }
}
