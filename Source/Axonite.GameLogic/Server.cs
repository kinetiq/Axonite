using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.World;
using Axonite.GameLogic.Loaders;
using Axonite.GameLogic.Turns;

namespace Axonite.GameLogic
{
    public class Server
    {
        private GameStates GameState = GameStates.GameNotStarted;
        private MatchTypes MatchType = MatchTypes.NotSet;
        private List<ICreature> Bots = null;
        
        public Server()
        {

        }

        public void StartGame(MatchTypes matchType)
        {
            if (GameState != GameStates.GameNotStarted)
                throw new InvalidOperationException();

            var Loader = new BotLoader();
            Bots = Loader.LoadBotsFromAssemblies();
 
            //Validate/prune bots.           
            //Assign bots locations in space.

            MatchType = matchType;
            GameState = GameStates.GameOn;
        }

        public void ExecuteTurn()
        {
            //Each bot has a chance to take a turn.

            GameState = GameStates.GameOver;
        }
    }
}
