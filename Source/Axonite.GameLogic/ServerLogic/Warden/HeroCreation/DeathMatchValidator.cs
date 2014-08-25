using Axonite.Core.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.ServerLogic.Warden.HeroCreation
{
    class DeathMatchValidator : IValidationStrategy
    {
        public IOutcome Validate(IHero hero)
        {
            return Outcomes.Success();
        }
    }
}
