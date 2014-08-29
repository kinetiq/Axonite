using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.Evaluations;
using Axonite.Core;
using Axonite.Core.World;

namespace Axonite.API
{
    public static class Evaluation
    {
        public static List<Hero> Look()
        {
            //Temp: convert all the HeroStates into read only heroes that the user can see... And since everything exists in
            //one location for now, everyone sees everything.
            var heroes = MapService.GetHeroes();
            var result = heroes.Select(hero => new Hero(hero)).ToList();

            return result;
        } 
    }
}
