namespace Dice_Roll_Game.UI
{
    // This class is responsible for all console output
    static class MessagePrinter
    {
        public static void Welcome()
        {
            Console.WriteLine("*************** Dice Roll Game ***************");
            Console.WriteLine("====================================================");
        }

        public static void GuessTheNumber()
        {
            Console.WriteLine("Please enter your guess: ");
        }

        public static void PrintInvalidInput()
        {
            Console.WriteLine("Input is invalid. Enter a valid number.");
        }

        public static void PrintOutOfRangeInput()
        {
            Console.WriteLine("Input is out of range. it must be from 1 to 6.");
        }

        public static void PrintNumberOfRemainingAttempts(int remainingTries)
        {
            Console.WriteLine($"{remainingTries}  attempts remaining!\n");
        }

        public static void PrintWrongNumber()
        {
            Console.WriteLine("Wrong number. 😢");
        }

        public static void PrintWin()
        {
            Console.WriteLine("You win ! 😁");
        }

        public static void PrintLose()
        {
            Console.WriteLine("You lose. 😔");
        }

        public static void PrintFinishGame()
        {
            Console.WriteLine("*************** The Game is finished ***************");
        }

        public static void AskForNumberOfTries()
        {
            Console.WriteLine("Enter number of tries (A Valid number from 1 to 4): ");
        }
    }
}
