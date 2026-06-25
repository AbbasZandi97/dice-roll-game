using Dice_Roll_Game.Models;
using Dice_Roll_Game.UI;

namespace Dice_Roll_Game.Services
{
    // This class handles the logic
    internal class GameService
    {
        private Game _game;
        private Random _random = new Random();

        public void StartGame()
        {
            MessagePrinter.Welcome();
            int tries = InputHandler.GetNumberOfTries();
            _game = new Game(tries);
            GenerateRandomNum();    

            do
            {
                int guess = InputHandler.GetInput();

                if (IsGuessTrue(guess))
                {
                    MessagePrinter.PrintWin();
                    break;
                }

                _game.DecreaseNumOfAttempts();
                MessagePrinter.PrintNumberOfRemainingAttempts(_game.NumOfAttempts);


                if (IsNumOfAttemptsZero())
                {
                    MessagePrinter.PrintLose();
                    Console.WriteLine($"The correct number is: {_game.RandomNum}");
                    break;
                }


            }
            while (true);

            MessagePrinter.PrintFinishGame();
        }

        private void GenerateRandomNum()
        {
            int randomNumber = _random.Next(1, 7);
            _game.SetRandomNum(randomNumber);
        }

        public bool IsGuessTrue(int guess)
        {
            bool isGuessTrue = guess == _game.RandomNum;

            if (!isGuessTrue) MessagePrinter.PrintWrongNumber();

            return isGuessTrue;

        }

        public bool IsNumOfAttemptsZero()
        {
            return _game.NumOfAttempts == 0;
        }


        
    }
}
