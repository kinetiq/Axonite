using System;
using System.Collections.Generic;
using Axonite.Core.Singletons;
using Axonite.Core.World;

namespace Axonite.Core
{
    /// <summary>
    /// Temporary map state service. Rejigger once we have a real map. 
    /// Need some way of referenceing heroes without passing the reference around! 
    /// </summary>
    internal static class MapService
    {
        private static readonly GameMap GameMapState = GameMapSingleton.Instance.Map;

        public static void Add(HeroState hero)
        {
            GameMapState.m_HeroList.Add(hero);
        }

        internal static IReadOnlyCollection<HeroState> GetHeroes()
        {
            return GameMapState.HeroList();
        }

        internal static void Remove(HeroState hero)
        {
            GameMapState.m_HeroList.Remove(hero);
        }
    }
}
