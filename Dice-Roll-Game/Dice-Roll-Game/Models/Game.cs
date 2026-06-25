namespace Dice_Roll_Game.Models
{
    // This class holds the game's state
    internal class Game
    {
        public int NumOfAttempts { get; private set; }

        public int RandomNum { get; private set; }

        public Game(int numberOfTries)
        {
            NumOfAttempts = numberOfTries;
        }

        public void SetRandomNum(int generatedNumber)
        {
            RandomNum = generatedNumber;
        }

        public void DecreaseNumOfAttempts()
        {
            NumOfAttempts--;
        }
    }
}
