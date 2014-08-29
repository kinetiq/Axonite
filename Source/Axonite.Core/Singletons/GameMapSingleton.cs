using System.Collections.Generic;
using Axonite.Core.World;

namespace Axonite.Core.Singletons
{
    internal sealed class GameMapSingleton
    {
        static readonly GameMapSingleton InnerInstance = new GameMapSingleton();
        internal GameMap Map = new GameMap();

        internal static GameMapSingleton Instance
        {
            get
            {
                return InnerInstance;
            }
        }

        GameMapSingleton()
        {
            // Initialize.
        }
    }
}
