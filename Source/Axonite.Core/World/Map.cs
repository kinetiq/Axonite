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
        internal List<IHero> m_HeroList = new List<IHero>();

        public ReadOnlyCollection<IHero> HeroList()
        {
            return new ReadOnlyCollection<IHero>(m_HeroList);
        } 
    }
}
