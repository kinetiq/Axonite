using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.World;
using Axonite.GameLogic.Turns;
using Axonite.GameLogic.Warden;

namespace Axonite.GameLogic.Loaders
{
    class HeroLoader
    {
        public static List<IHero> LoadHeroes(MatchTypes matchType)
        {
            var AllHeroes = HeroImporter.ImportHeroesFromAssemblies();

            var Validator = new HeroValidator(AllHeroes, matchType);
            var ValidHeroesOutcome = Validator.GetValidHeroes();

            if (!ValidHeroesOutcome.Success)
                throw new InvalidOperationException("Failure filtering valid heroes: " + ValidHeroesOutcome);

            if (ValidHeroesOutcome.Messages.Count > 0)
            {
                //Show messages?
            }

            return ValidHeroesOutcome.Value;
        }
    }
}
