using System.Collections.Generic;
using Axonite.Core.World;

namespace Axonite.GameState.Singletons
{
    internal sealed class HeroStateDictionarySingleton
    {
        static readonly HeroStateDictionarySingleton InnerInstance = new HeroStateDictionarySingleton();

        internal Dictionary<IHero, HeroState> HeroStateDictionary = new Dictionary<IHero, HeroState>();
        internal List<IHero> Heroes = new List<IHero>(); 

        internal static HeroStateDictionarySingleton Instance
        {
            get
            {
                return InnerInstance;
            }
        }
        HeroStateDictionarySingleton()
        {
            // Initialize.
        }
    }
}
