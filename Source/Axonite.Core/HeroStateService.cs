using System;
using System.Collections.Generic;
using Axonite.Core.World;

namespace Axonite.Core
{
    /// <summary>
    /// Temporary map state service. Rejigger once we have a real map. 
    /// Need some way of referenceing heroes without passing the reference around! 
    /// </summary>
    internal static class MapStateService
    {
        private static readonly Map MapState = new Map();

        public static void Add(IHero hero)
        {
            MapState.m_HeroList.Add(hero);
        }

        internal static IReadOnlyCollection<IHero> GetHeroes()
        {
            return MapState.HeroList();
        }

        internal static void Remove(IHero hero)
        {
            MapState.m_HeroList.Remove(hero);
        }
    }
}
