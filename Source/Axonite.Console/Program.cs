using Axonite.GameLogic;
using Axonite.GameLogic.ServerLogic.Turns;

namespace Axionite.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var Server = new Server();
            Server.StartGame(GameTypes.DeathMatch);
            Server.ExecuteTurn();


            //var z = new Axonite.GameLogic.Loaders.HeroLoader();
            //z.LoadBotsFromAssemblies();


            //Call GameLogic.Server and loop. On each loop: run a turn, and update the UI. Stop when the server says the game is over.
        }
    }
}
