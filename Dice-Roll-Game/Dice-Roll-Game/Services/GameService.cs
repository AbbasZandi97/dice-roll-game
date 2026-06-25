using Dice_Roll_Game.Models;
using Dice_Roll_Game.UI;

namespace Dice_Roll_Game.Services
{
    // This class handles the logic
    internal class GameService
    {
        private Game game;

        public GameService()
        {
            game = new Game();
        }
        
        public void StartGame()
        {
            MessagePrinter.Welcome();
            GenerateRandomNum();

            do
            {
                int guess = InputHandler.GetInput();

                if (IsGuessTrue(guess))
                {
                    MessagePrinter.PrintWin();
                    break;
                }

                game.DecreaseNumOfAttempts();

                if (IsNumOfAttemptsZero())
                {
                    MessagePrinter.PrintLose();
                    Console.WriteLine($"The correct number is: {game.RandomNum}");
                    break;
                }


            }
            while (true);

            MessagePrinter.PrintFinishGame();
        }

        private void GenerateRandomNum()
        {
            Random random = new Random();
            int maxValueOfDice = 6;
            int randomNumber = random.Next(1, 7);
            game.SetRandomNum(randomNumber);
        }

        public bool IsGuessTrue(int guess)
        {
            bool isGuessTrue = guess == game.RandomNum;

            if (!isGuessTrue) MessagePrinter.PrintWrongNumber();

            return isGuessTrue;

        }

        public bool IsNumOfAttemptsZero()
        {
            return game.NumOfAttempts == 0;
        }


        
    }
}
