using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.Core.World;
using Axonite.GameLogic.Turns;

namespace Axonite.GameLogic
{
    public static class GameState
    {
        public static GameStates GameState = GameStates.GameNotStarted;
        public static MatchTypes MatchType = MatchTypes.NotSet;
        public static List<IHero> Heroes = null;

        static GameState()
        {
            
        }

    }
}
