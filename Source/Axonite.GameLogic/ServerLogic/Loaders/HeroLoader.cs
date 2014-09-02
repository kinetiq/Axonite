using System.Collections.Generic;
using Axonite.Core;
using Axonite.Core.World;
using Axonite.GameLogic.ServerLogic.Turns;
using Axonite.GameLogic.ServerLogic.Warden;
using Ether.Outcomes;

namespace Axonite.GameLogic.ServerLogic.Loaders
{
    internal class HeroLoader
    {
        internal static IOutcome<List<IHero>> LoadHeroes(GameTypes gameType)
        {
            var AllHeroes = HeroImporter.ImportHeroesFromAssemblies();
            InitializeHeroState(AllHeroes);
            var Validator = new HeroValidator(AllHeroes, gameType);
            var ValidHeroesOutcome = Validator.GetValidHeroes();

            return ValidHeroesOutcome;
        }

        private static void InitializeHeroState(IEnumerable<IHero> heroes)
        {
            foreach (var Hero in heroes)
            {
                HeroRepository.RegisterAndInitializeState(Hero);
                Hero.Setup();
            }

        }
    }
}
