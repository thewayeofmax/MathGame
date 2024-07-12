using System;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            User user = new User();
            GamesHistory history = new GamesHistory();
            GameStatus status = new GameStatus();

            user.userLogin();
            status.startGame();
            while (status.statusOfGame() != false)
            {
                menu.showOperations();
                (bool, int) data = menu.inputValidation(menu.getOperation());
                menu.userChoiceAction(data);
            }
        }

    }
}
