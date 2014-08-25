using System;
using Axonite.GameLogic.ServerLogic.Turns;

namespace Axonite.GameLogic.ServerLogic.Warden.HeroCreation
{
    static class ValidationStrategyFactory
    {
        public static IValidationStrategy GetValidatorFor(GameTypes gameType)
        {
            switch (gameType)
            {
                case GameTypes.DeathMatch:
                    return new DeathMatchValidator();
                default:
                    throw new InvalidOperationException("Unexpected MatchType: " + gameType);
            }

        }
    }
}
