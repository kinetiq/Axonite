using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.Core.World;
using Axonite.GameLogic.ServerLogic.Turns;

namespace Axonite.GameLogic
{
    /// <summary>
    /// Ecapsulates game state including the map, heroes, etc.
    /// </summary>
    internal static class Game
    {
        internal static GameStates GameState = GameStates.GameNotStarted;
        internal static GameTypes GameType = GameTypes.NotSet;

        static Game()
        {
            
        }

    }
}
