using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.World;

namespace Axonite.GameLogic.Loaders
{
    public class BotLoader
    {
        [ImportMany(typeof(ICreature))]
        private List<ICreature> Creatures;

        public List<ICreature> LoadBotsFromAssemblies()
        {
            var Catalog = new AggregateCatalog(); //We can add multiple catalogs to this. 

            //Rifle through all the catalogs in the exectuing folder, and pull the ones that implement our interface.
            Catalog.Catalogs.Add(GetExecutionDirectoryCatalog()); 

            var Container = new CompositionContainer(Catalog);
            Container.ComposeParts(this); //After this, Creatures will contain instances of all our StockBots!

            return new List<ICreature>(Creatures); //Copy the list.
        }

        private DirectoryCatalog GetExecutionDirectoryCatalog()
        {
            //This registration makes it easier to implement new bots, because you won't have to put in the [Export(...)] attribute.
            var Registration = new RegistrationBuilder();

            Registration.ForTypesDerivedFrom<ICreature>()
                        .Export<ICreature>();


            var ExecutionPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new DirectoryCatalog(ExecutionPath, Registration);          
        }
    }
}
