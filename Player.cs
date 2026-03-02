namespace Exercise8Singleton;

public class Player
{
    public string Name { get; }

    public Player(string name)
    {
        Name = name;
    }

    public void ScorePoints(int points)
    {
        //TODO: Call Scoreboard Singleton Instance AddScore Method
        Scoreboard.GetInstance().AddScore(Name, points);
    }

}