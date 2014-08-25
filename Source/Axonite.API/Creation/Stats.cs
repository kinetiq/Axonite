using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.Core;
using Axonite.Core.World;

namespace Axonite.API.Creation
{
    public static class Stats 
    {
        public static void SetHealth(IHero hero, int value)
        {
            var HeroState = HeroStateService.Find(hero);
            HeroState.Health = value;
        }
    }
}
