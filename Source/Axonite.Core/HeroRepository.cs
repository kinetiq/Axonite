using System;
using System.Collections.Generic;
using System.Dynamic;
using Axonite.Core.Singletons;
using Axonite.Core.World;

namespace Axonite.Core
{
    /// <summary>
    /// Heroes need to be truly unaware of their state (as well as the state of other heroes) and unable to directly alter it, to prevent cheating. 
    /// But API and GameLogic both need access. We achieved this by putting this internal repository here. GameLogic and API are both declared 
    /// CanSeeInternals, so they basically have Public access, while Hero DLLs don't see it at all.
    /// </summary>
    internal static class HeroRepository
    {
        private static readonly Dictionary<IHero, HeroState> HeroStateDictionary = HeroStateDictionarySingleton.Instance.HeroStateDictionary;
        private static readonly List<IHero> HeroList = HeroStateDictionarySingleton.Instance.Heroes; 
       
        public static void RegisterAndInitializeState(IHero hero)
        {
            if (HeroStateDictionary.ContainsKey(hero))
                return;

            //When we add a new hero, we initialize a new empty state for it.
            var NewHeroState = new HeroState(hero);

            HeroList.Add(hero);
            HeroStateDictionary.Add(hero, NewHeroState);
        }

        internal static HeroState FindState(IHero hero)
        {
            if (HeroStateDictionary.ContainsKey(hero))
                return HeroStateDictionary[hero];

            throw new InvalidOperationException("Hero was not found in the registry.");
        }

        internal static List<IHero> Heroes
        {
            get
            {
                 return HeroList;
            }
            set { HeroStateDictionarySingleton.Instance.Heroes = value; }
        }

        internal static void Remove(IHero hero)
        {
            if (HeroStateDictionary.ContainsKey(hero))
                HeroStateDictionary.Remove(hero);

            if (HeroList.Contains(hero))
                HeroList.Remove(hero);
        }
    }
}
