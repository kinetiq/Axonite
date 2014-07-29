using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.GameLogic.Turns;

namespace Axonite.GameLogic.Warden.Validation
{
    static class ValidationStrategyFactory
    {
        public static IValidationStrategy GetValidatorFor(MatchTypes matchType)
        {
            switch (matchType)
            {
                case MatchTypes.DeathMatch:
                    return new DeathMatchHeroValidator();
                default:
                    throw new InvalidOperationException("Unexpected MatchType: " + matchType);
            }

        }
    }
}
