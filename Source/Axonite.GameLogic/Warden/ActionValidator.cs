using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.Actions;
using Axonite.Core.Actions;
using Axonite.Core.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.Warden
{
    public class ActionValidator
    {
        public static IOutcome ValidateAction(IHero hero, IAction action)
        {
            return Outcomes.Success();
        }
    }
}
