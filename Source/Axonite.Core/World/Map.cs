using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axonite.Core.World
{
    public class Map
    {
        //For now, just assuming a single location...
        internal List<HeroState> m_HeroList = new List<HeroState>();

        public ReadOnlyCollection<HeroState> HeroList()
        {
            return new ReadOnlyCollection<HeroState>(m_HeroList);
        } 
    }
}
