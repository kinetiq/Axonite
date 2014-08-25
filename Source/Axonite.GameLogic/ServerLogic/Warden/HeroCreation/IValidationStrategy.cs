using Axonite.Core.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.ServerLogic.Warden.HeroCreation
{
    interface IValidationStrategy
    {
        IOutcome Validate(IHero hero);
    }
}
