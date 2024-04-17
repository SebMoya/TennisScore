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
        Player1.Score = 0;
        Player2.Score = 0;
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
                return "Game Player1";
            }
            else if (Player2.Score > Player1.Score + 1)
            {
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

        //switch (score)
        //{
        //    case 0:
        //        return "Love";
        //    case 1:
        //        return "Fifteen";
        //    case 2:
        //        return "Thirty";
        //    case 3:
        //        return "Forty";
        //    default:
        //        return score.ToString();
    }
}
