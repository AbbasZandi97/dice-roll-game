namespace Dice_Roll_Game.UI
{
    // The class is responsible for reading and validating user input
    internal class InputHandler
    {
        public static int GetInput()
        {
            string input;
            do
            {
                MessagePrinter.GuessTheNumber();
                input = Console.ReadLine();
            }
            while (!IsInputValid(input));

            return int.Parse(input);

        }

        public static bool IsInputValid(string input)
        {
            bool isValid = int.TryParse(input, out int parsedInput);

            if (!isValid) MessagePrinter.PrintInvalidInput();

            if (isValid && (parsedInput < 1 || parsedInput > 6))
            {
                MessagePrinter.PrintOutOfRangeInput();
                return false;
            }

            return isValid;
        }

        public static int GetNumberOfTries()
        {
            string input;
            int tries;
            do
            {
                MessagePrinter.AskForNumberOfTries(); 
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out tries) || tries < 1 || tries > 4);

            return tries;
        }

        public static bool AskToPlayAgain()
        {
            string input;
            do
            {
                Console.WriteLine("Play again? (y/n): ");
                input = Console.ReadLine();

                if (input == "y" || input == "Y") return true;
                if (input == "n" || input == "N") return false;

                Console.WriteLine("Invalid input. Please enter y or n.");
            }
            while (true);
        }
    }
}
