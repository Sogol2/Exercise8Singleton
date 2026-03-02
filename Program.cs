namespace Exercise8Singleton;

class Program
{
    static void Main(string[] args)
    {
        
        List<Player> players = new List<Player>
        {
            new Player("Knight"),
            new Player("Wizard"),
            new Player("Archer"),
            new Player("Rogue"),
            new Player("Cleric")
        };

        Random random = new Random();
        int rounds = 10;

        Console.WriteLine("Welcome to the RPG Battle Arena!");
        Console.WriteLine("Players: Knight, Wizard, Archer, Rogue, Cleric\n");
        Console.WriteLine("Starting battle...\n");

        
        for (int i = 1; i <= rounds; i++)
        {
            Console.WriteLine($"--- Round {i} ---");

            // Pick a random player
            int playerIndex = random.Next(players.Count);
            Player currentPlayer = players[playerIndex];

            // Generate random score between 5 and 20
            int points = random.Next(5, 21);

            currentPlayer.ScorePoints(points);

            Thread.Sleep(500); // Small delay for dramatic effect
        }

        Console.WriteLine("\nFinal Results");
        //TODO: Call Singleton Instance DisplayScores() method.
        Scoreboard.DisplayScores();
    }
}

