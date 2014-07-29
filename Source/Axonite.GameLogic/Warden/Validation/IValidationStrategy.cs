using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.World;
using Ether.Outcomes;

namespace Axonite.GameLogic.Warden.Validation
{
    interface IValidationStrategy
    {
        IOutcome Validate(IHero hero);
    }
}
