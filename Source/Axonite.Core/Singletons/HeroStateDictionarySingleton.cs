using System.Collections.Generic;
using Axonite.Core.World;

namespace Axonite.Core.Singletons
{
    internal sealed class HeroStateDictionarySingleton
    {
        static readonly HeroStateDictionarySingleton InnerInstance = new HeroStateDictionarySingleton();
        internal Dictionary<IHero, HeroState> HeroStateDictionary = new Dictionary<IHero, HeroState>();

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
