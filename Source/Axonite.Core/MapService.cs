using System;
using System.Collections.Generic;
using Axonite.Core.World;

namespace Axonite.Core
{
    /// <summary>
    /// Temporary map state service. Rejigger once we have a real map. 
    /// Need some way of referenceing heroes without passing the reference around! 
    /// </summary>
    internal static class MapService
    {
        private static readonly Map MapState = new Map();

        public static void Add(HeroState hero)
        {
            MapState.m_HeroList.Add(hero);
        }

        internal static IReadOnlyCollection<HeroState> GetHeroes()
        {
            return MapState.HeroList();
        }

        internal static void Remove(HeroState hero)
        {
            MapState.m_HeroList.Remove(hero);
        }
    }
}
