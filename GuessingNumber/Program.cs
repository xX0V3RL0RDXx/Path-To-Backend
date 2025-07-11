void game(int min, int max)
{
    Console.WriteLine($"Try to guess number between {min} and {max}:");
    Random rnd = new Random();
    int randomNumber = rnd.Next(min, max);
    int userInput = 0;
    while (true)
    {
        try
        {
            Console.WriteLine("Try guess!");
            userInput = Int32.Parse(Console.ReadLine());
            if (userInput == randomNumber)
            {
                Console.WriteLine($"You are right! The number is {randomNumber}");
                break;
            }
                
        }catch (Exception) {
            Console.WriteLine("Invalid input");
        }
    }
}

int min = 0;
int max = 100;

game(min,max);
