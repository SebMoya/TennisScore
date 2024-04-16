namespace TennisScore.Manager;

public class SetManager
{
    public int Player1Set { get; set; }
    public int Player2Set { get; set;}

    public void Player1SetScore()
    {
        Player1Set++;
    }

    public void Player2SetScore()
    {
        Player2Set++;
    }

}