using Axonite.API.Actions;
using Axonite.Core;
using Axonite.Core.World;
using Axonite.GameLogic.ServerLogic.Turns;
using Axonite.GameLogic.ServerLogic.Warden;
using System;
using Axonite.GameState;

namespace Axonite.GameLogic.ServerLogic
{
    internal class ExecuteTurnService
    {
        internal static TurnResults ExecuteTurn()
        {
            if (Game.GameState != GameStates.GameOn)
                throw new InvalidOperationException();

            foreach (var Hero in HeroRepository.Heroes)
                ExecuteTurn(Hero);

            //Check victory condititons
            Game.GameState = GameStates.GameOver;
            return TurnResults.GameOver;
        }

        private static void ExecuteTurn(IHero hero)
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
