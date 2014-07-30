using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.Core.World;
using Axonite.GameLogic.Turns;
using Axonite.GameLogic.Warden;
using Ether.Outcomes;

namespace Axonite.GameLogic.Loaders
{
    class HeroLoader
    {
        public static IOutcome<List<IHero>> LoadHeroes(MatchTypes matchType)
        {
            var AllHeroes = HeroImporter.ImportHeroesFromAssemblies();

            var Validator = new HeroValidator(AllHeroes, matchType);
            var ValidHeroesOutcome = Validator.GetValidHeroes();

            return ValidHeroesOutcome;
        }
    }
}
