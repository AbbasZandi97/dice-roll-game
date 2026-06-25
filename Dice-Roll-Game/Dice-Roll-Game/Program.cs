using Dice_Roll_Game.Services;
using System.Text;
namespace Dice_Roll_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this line makes sure emojis in the code are shown perfectly on the console
            Console.OutputEncoding = Encoding.UTF8;
           
            new GameService().StartGame();
        }
    }
}
