using TennisScore.Models;

namespace TennisScore.Manager;

public class SetManager
{
    public PlayerModel Player1 { get; set; }
    public PlayerModel Player2 { get; set; }


    public void Player1SetScore()
    {
        Player1.Set++;
    }

    public void Player2SetScore()
    {
        Player2.Set++;
    }

}