using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class GameStatus
    {
        private bool gameStatus = false;

        public void stopGame()
        {
            gameStatus = false;
        }

        public void startGame()
        {
            gameStatus = true;
        }

        public bool statusOfGame()
        {
            return gameStatus;
        }
    }
}
