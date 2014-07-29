namespace Axionite.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = new Axonite.GameLogic.Loaders.BotLoader();
            z.LoadBotsFromAssemblies();


            //Call GameLogic.Server and loop. On each loop: run a turn, and update the UI. Stop when the server says the game is over.
        }
    }
}
