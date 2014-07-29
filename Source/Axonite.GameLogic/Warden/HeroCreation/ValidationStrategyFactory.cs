using System;
using Axonite.GameLogic.Turns;

namespace Axonite.GameLogic.Warden.HeroCreation
{
    static class ValidationStrategyFactory
    {
        public static IValidationStrategy GetValidatorFor(MatchTypes matchType)
        {
            switch (matchType)
            {
                case MatchTypes.DeathMatch:
                    return new DeathMatchValidator();
                default:
                    throw new InvalidOperationException("Unexpected MatchType: " + matchType);
            }

        }
    }
}
