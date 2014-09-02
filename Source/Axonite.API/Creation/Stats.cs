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
            var HeroState = HeroRepository.FindState(hero);
            HeroState.Health = value;
        }

        public static void SetStrength(IHero hero, int value)
        {
            var HeroState = HeroRepository.FindState(hero);
            HeroState.Strength = value;
        }
    }
}
