using System;
using System.Collections.Generic;
using Axonite.Core.World;

namespace Axonite.GameLogic.ServerLogic
{
    /// <summary>
    /// For heroes to be truly agnostic of their state, we need to put the state in a seperate object and introduce tools that
    /// provide access only to the proper places.
    /// </summary>
    public static class HeroStateService
    {
        private static readonly Dictionary<IHero, HeroState> HeroStateMap = new Dictionary<IHero, HeroState>();

        public static void RegisterAndInitializeState(IHero hero)
        {
            if (HeroStateMap.ContainsKey(hero))
                return;

            //When we add a new hero, we initialize a new empty state for it.
            var NewHeroState = new HeroState(hero);

            HeroStateMap.Add(hero, NewHeroState);
        }

        public static HeroState Find(IHero hero)
        {
            if (HeroStateMap.ContainsKey(hero))
                return HeroStateMap[hero];

            throw new InvalidOperationException("Hero was not found in the registry.");
        }

    }
}
