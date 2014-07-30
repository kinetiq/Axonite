using Axonite.Core.Actions;

namespace Axonite.Core.World
{
    public interface IHero
    {
        void Setup();
        IAction DetermineAction();
    }
}
