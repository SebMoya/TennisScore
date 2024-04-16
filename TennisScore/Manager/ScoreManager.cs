namespace TennisScore.Manager;

public class ScoreManager
{
    public int Player1Score { get; set; }

    public int Player2Score { get; set; }


    public void Player1Scored()
    {
        Player1Score++;
    }

    public void Player2Scored()
    {
        Player2Score++;
    }

    public string GetScore()
    {
        if (Player1Score >= 3 && Player2Score >= 3)
        {
            if (Player1Score == Player2Score)
            {
                return "Deuce";
            }
            else if (Player1Score == Player2Score + 1)
            {
                return "Advantage Player1";
            }
            else if (Player2Score == Player1Score + 1)
            {
                return "Advantage Player2";
            }
            else if (Player1Score > Player2Score + 1)
            {
                return "Game Player1";
                SetManager.Player1SetScore();
            }
            else if (Player2Score > Player1Score + 1)
            {
                return "Game Player2";
                SetManager.Player2SetScore();
            }
        }
        else
        {
            return $"{GetScoreName(Player1Score)} - {GetScoreName(Player2Score)}";
        }

        return "";
    }

    private string GetScoreName(int score)
    {
        switch (score)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            case 3:
                return "Forty";
            default:
                return "";
        }
    }
}