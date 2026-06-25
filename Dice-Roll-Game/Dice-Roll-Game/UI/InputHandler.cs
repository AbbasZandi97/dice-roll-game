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
            bool isValid = int.TryParse(input, out _);

            if (!isValid) MessagePrinter.PrintInvalidInput();

            return isValid;
        }

    }
}
