namespace Dice_Roll_Game.UI
{
    // This class is responsible for all console output
    static class MessagePrinter
    {
        public static void Welcome()
        {
            Console.WriteLine("*************** Dice Roll Game ***************");
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
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
    }
}
