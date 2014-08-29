using Axonite.API.Actions;
using Axonite.API.Creation;
using Axonite.Core.Actions;
using Axonite.Core.World;

namespace StockHeroes
{
    public class Sven : IHero
    {
        public void Setup()
        {
            Stats.SetHealth(this, 3);
            Stats.SetStrength(this, 7);
        }

        public IAction DetermineAction()
        {
            return new PassAction();
        }
    }
}
