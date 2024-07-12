using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GamesHistory
    {
        private List<Tuple<User, int, DateTime>> historyGames = new List<Tuple<User, int, DateTime>>();

        public void addGame(User user, int points, DateTime date) => historyGames.Add(Tuple.Create(user, points, date));

        public List<Tuple<User, int, DateTime>> getHistoryList() => historyGames;
        
            
        
    }
}
