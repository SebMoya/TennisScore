using System.Text;
using TennisScore.Enum;
using TennisScore.Models;

namespace TennisScore.Manager;

public class ScoreManager
{
    public PlayerModel Player1 { get; set; }
    public PlayerModel Player2 { get; set; }

    public ScoreManager()
    {
        Player1 = new PlayerModel();
        Player2 = new PlayerModel();
    }

    public void Player1Scored()
    {
        Player1.Score++;
    }

    public void Player2Scored()
    {
        Player2.Score++;
    }

    public string GetScore()
    {
        if (Player1.Score >= 3 && Player2.Score >= 3)
        {
            if (Player1.Score == Player2.Score)
            {
                return "Deuce";
            }
            else if (Player1.Score == Player2.Score + 1)
            {
                return "Advantage Player1";
            }
            else if (Player2.Score == Player1.Score + 1)
            {
                return "Advantage Player2";
            }
            else if (Player1.Score > Player2.Score + 1)
            {
                Player1.WonGames++;
                if (Player1.WonGames == 6 && Player2.WonGames.Equals(Player1.WonGames-3))
                {
                    Player1.WonGames = 0;
                    Player2.WonGames = 0;
                    Player1.Set++;
                }
                return "Game Player1";
            }
            else if (Player2.Score > Player1.Score + 1)
            {
                Player2.WonGames++;
                if (Player2.WonGames == 6 && Player1.WonGames.Equals(Player2.WonGames-3))
                {
                    Player1.WonGames = 0;
                    Player2.WonGames = 0;
                    Player2.Set++;
                }
                return "Game Player2";
            }
        }
        else
        {
            return $"{GetScoreName(Player1.Score)} - {GetScoreName(Player2.Score)}";
        }

        return "";
    }

    private string GetScoreName(int score)
    {
        var scoreNames = ScoreNames.GetName(typeof(ScoreNames), score);
        if (scoreNames != null)
        {
            return scoreNames;
        }

        return score.ToString();
    }
}
