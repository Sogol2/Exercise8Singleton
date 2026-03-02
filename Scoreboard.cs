namespace Exercise8Singleton;

public class Scoreboard
{
    private Dictionary<string, int> _scores = new Dictionary<string, int>();
    
    //TODO: Create Singleton Instance variable
    private static Scoreboard _instance;

    //TODO: Define Singleton Constructor
    private Scoreboard()
    {
        _scores = new Dictionary<string, int>();
    }

    //TODO: Define Singleton GetInstance() method
    public static Scoreboard GetInstance()
    {
        if (_instance == null)
            _instance = new Scoreboard();
        return _instance;
    }
    public static void AddScore(string player, int points)
    {
        if (_scores.ContainsKey(player))
            _scores[player] += points;
        else
            _scores[player] = points;

        Console.WriteLine($"[{DateTime.Now}] {player} scored {points} points! | Scoreboard Hash: {_instance.GetHashCode()}");
    }

    public void DisplayScores()
    {
        Console.WriteLine("\n=== Current Scores ===");
        foreach (var entry in _scores.OrderByDescending(s => s.Value))
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        Console.WriteLine("=======================\n");
    }


}
