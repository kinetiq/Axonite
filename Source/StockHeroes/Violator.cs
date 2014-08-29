using Axonite.API.Actions;
using Axonite.API.Creation;
using Axonite.Core.Actions;
using Axonite.Core.World;

namespace StockHeroes
{
    public class Violator : IHero
    {
        public void Setup()
        {
            Stats.SetHealth(this, 7);
            Stats.SetStrength(this, 3);
        }

        public IAction DetermineAction()
        {
            return new PassAction();
        }
    }
}
