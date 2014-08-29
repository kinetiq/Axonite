using System.Collections.Generic;
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
            var allHeroes = HeroImporter.ImportHeroesFromAssemblies();
            InitializeHeroState(allHeroes);
            var validator = new HeroValidator(allHeroes, gameType);
            var validHeroesOutcome = validator.GetValidHeroes();

            return validHeroesOutcome;
        }

        private static void InitializeHeroState(IEnumerable<IHero> heroes)
        {
            foreach (var hero in heroes)
            {
                HeroStateService.RegisterAndInitializeState(hero);
                hero.Setup();
            }

        }
    }
}
