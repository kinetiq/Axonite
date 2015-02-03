using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.Core.World;
using Axonite.GameLogic.ServerLogic.Loaders;
using Axonite.GameLogic.ServerLogic.Turns;

namespace Axonite.GameLogic.ServerLogic
{
    internal class StartGameService
    {
        public static void StartGame(GameTypes gameType)
        {
            if (Game.GameState != GameStates.GameNotStarted)
                throw new InvalidOperationException();

            var LoadOutcome = HeroLoader.LoadHeroes(gameType);

            if (!LoadOutcome.Success)
                throw new InvalidOperationException("Failure filtering valid heroes: " + LoadOutcome);

            if (LoadOutcome.Messages.Count > 0)
            {
                //Show messages?
            }

        
            //Arrange the game map
            //Arrange the heroes in space

            Game.GameType = gameType;
            Game.GameState = GameStates.GameOn;
        }
    }
}
