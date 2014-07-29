using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Axonite.API.World;
using Axonite.GameLogic.Loaders;
using Axonite.GameLogic.Turns;
using Axonite.GameLogic.Warden;

namespace Axonite.GameLogic
{
    public class Server
    {

        private GameStates GameState = GameStates.GameNotStarted;
        private MatchTypes MatchType = MatchTypes.NotSet;
        private List<IHero> Heroes = null;
        
        public Server()
        {

        }

        public void StartGame(MatchTypes matchType)
        {
            if (GameState != GameStates.GameNotStarted)
                throw new InvalidOperationException();

            Heroes = HeroLoader.LoadHeroes(matchType);
            MatchType = matchType;
            GameState = GameStates.GameOn;
        }

        public void ExecuteTurn()
        {
            if (GameState != GameStates.GameOn)
                throw new InvalidOperationException();

            foreach (var Hero in Heroes)
                ExecuteTurn(Hero);

            GameState = GameStates.GameOver;
        }

        private void ExecuteTurn(IHero hero)
        {
            //...Action   = Hero.DetermineAction
            //...Governor.ValidateAction(Action) 
            //...Execute.Action or Action.Pass
        }
    }
}
