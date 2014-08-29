using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.IO;
using System.Reflection;
using Axonite.Core.World;

namespace Axonite.GameLogic.ServerLogic.Loaders
{
    public class HeroImporter
    {
        [ImportMany(typeof (IHero))] 
        private List<IHero> m_Heroes = null;

        private HeroImporter()
        {
            //Private constructor; using factory method pattern.
        }

        public static List<IHero> ImportHeroesFromAssemblies()
        {
            var loader = new HeroImporter();
            return loader.ImportHeroes();
        }

        private List<IHero> ImportHeroes()
        {
            var catalog = new AggregateCatalog(); //We can add multiple catalogs to this. 

            //Rifle through all the catalogs in the exectuing folder, and pull the ones that implement our interface.
            catalog.Catalogs.Add(GetExecutionDirectoryCatalog()); 

            var container = new CompositionContainer(catalog);
            container.ComposeParts(this); //After this, Heroes will contain instances of all our StockBots!

            return new List<IHero>(m_Heroes); //Copy the list.
        }

        private DirectoryCatalog GetExecutionDirectoryCatalog()
        {
            //This registration makes it easier to implement new bots, because you won't have to put in the [Export(...)] attribute.
            var registration = new RegistrationBuilder();

            registration
                .ForTypesDerivedFrom<IHero>()
                .Export<IHero>();

            var executionPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new DirectoryCatalog(executionPath, registration);          
        }
    }
}
