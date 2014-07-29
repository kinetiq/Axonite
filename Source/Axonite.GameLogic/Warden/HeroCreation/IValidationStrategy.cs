using Axonite.API.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.Warden.HeroCreation
{
    interface IValidationStrategy
    {
        IOutcome Validate(IHero hero);
    }
}
