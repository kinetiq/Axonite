using System;
using Axonite.API.Actions;
using Axonite.Core.Actions;
using Axonite.Core.World;

namespace Axonite.GameLogic.StockHeroes
{

    public class Sven : IHero
    {
        public void Setup()
        {
            throw new NotImplementedException();
        }

        public IAction DetermineAction()
        {
            return new PassAction();
        }
    }
}
