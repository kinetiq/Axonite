using Axonite.API.Actions;

namespace Axonite.API.World
{
    public interface IHero
    {
        void Setup();
        IAction DetermineAction();
    }
}
