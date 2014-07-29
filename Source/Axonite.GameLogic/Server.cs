using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Axonite.API.Actions;
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
        
        public void StartGame(MatchTypes matchType)
        {
            if (GameState != GameStates.GameNotStarted)
                throw new InvalidOperationException();

            var LoadOutcome = HeroLoader.LoadHeroes(matchType);
            
            if (!LoadOutcome.Success)
                throw new InvalidOperationException("Failure filtering valid heroes: " + LoadOutcome);

            if (LoadOutcome.Messages.Count > 0)
            {
                //Show messages?
            }

            Heroes = LoadOutcome.Value;

            //Arrange the game map
            //Arrange the heroes in space

            MatchType = matchType;
            GameState = GameStates.GameOn;
        }

        public void ExecuteTurn()
        {
            if (GameState != GameStates.GameOn)
                throw new InvalidOperationException();

            foreach (var Hero in Heroes)
                ExecuteTurn(Hero);

            //Check victory condititons
            GameState = GameStates.GameOver;
        }

        private void ExecuteTurn(IHero hero)
        {
            var Action = hero.DetermineAction();
            var Outcome = ActionValidator.ValidateAction(hero, Action);

            if (!Outcome.Success)
            {
                Action = new PassAction();
                //Show message?
            }

            ActionExecutor.Execute(hero, Action);
        }
    }
}
