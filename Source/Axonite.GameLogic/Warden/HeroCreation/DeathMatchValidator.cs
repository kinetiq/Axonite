using Axonite.Core.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.Warden.HeroCreation
{
    class DeathMatchValidator : IValidationStrategy
    {
        public IOutcome Validate(IHero hero)
        {
            return Outcomes.Success();
        }
    }
}
