using System;
using System.Collections.Generic;
using Axonite.Core.Singletons;
using Axonite.Core.World;

namespace Axonite.Core
{
    /// <summary>
    /// For heroes to be truly agnostic of their state, we need to put the state in a seperate object and introduce tools that
    /// provide access only to the proper places. However, the HeroStateService needs to be accessible from both the API and from Axonite.GameLogic, 
    /// but not to heroes declared in competitor libraries. So we just use InternalsVisibleTo for this.
    /// </summary>
    internal static class HeroStateService
    {
        private static readonly Dictionary<IHero, HeroState> HeroStateDictionary = HeroStateDictionarySingleton.Instance.HeroStateDictionary;

        public static void RegisterAndInitializeState(IHero hero)
        {
            if (HeroStateDictionary.ContainsKey(hero))
                return;

            //When we add a new hero, we initialize a new empty state for it.
            var newHeroState = new HeroState(hero);

            HeroStateDictionary.Add(hero, newHeroState);
        }

        internal static HeroState Find(IHero hero)
        {
            if (HeroStateDictionary.ContainsKey(hero))
                return HeroStateDictionary[hero];

            throw new InvalidOperationException("Hero was not found in the registry.");
        }

        internal static void Remove(IHero hero)
        {
            if (HeroStateDictionary.ContainsKey(hero))
                HeroStateDictionary.Remove(hero);
        }
    }
}
