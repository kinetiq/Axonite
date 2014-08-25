using Axonite.Core.Actions;
using Axonite.Core.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.ServerLogic.Warden
{
    public class ActionValidator
    {
        public static IOutcome ValidateAction(IHero hero, IAction action)
        {
            return Outcomes.Success();
        }
    }
}
