using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GamesHistory
    {
        private List<Tuple<int, DateTime>> historyGames = new List<Tuple<int, DateTime>>();

        public void addGame(int points, DateTime date) => historyGames.Add(Tuple.Create(points, date));

        public List<Tuple<int, DateTime>> getHistoryList() => historyGames;

        public void getHistory()
        {
            foreach (Tuple<int, DateTime> his in historyGames)
            {
                Console.WriteLine(his);
            }
        }
        
    }
}
