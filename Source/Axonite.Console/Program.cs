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
        }
    }
}
