using Axonite.GameLogic.ServerLogic;
using Axonite.GameLogic.ServerLogic.Turns;

namespace Axonite.GameLogic
{
    /// <summary>
    /// Entry point for starting, running, and interrogating games in progress.
    /// </summary>
    public class Server
    {                
        public void StartGame(GameTypes gameType)
        {
            StartGameService.StartGame(gameType);
        }

        public void ExecuteTurn()
        {
            var Result = ExecuteTurnService.ExecuteTurn();
        }
    }
}
