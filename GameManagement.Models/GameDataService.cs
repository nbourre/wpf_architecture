using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Models
{
    class GameDataService : IDataService<Game>
    {
        List<Game> games;

        public GameDataService()
        {
            initValues();
        }

        public IEnumerable<Game> GetAll()
        {
            foreach (Game g in games)
            {
                yield return g;
            }
        }

        private void initValues()
        {
            games = new List<Game>()
            {
                 
            };
        }
    }
}
