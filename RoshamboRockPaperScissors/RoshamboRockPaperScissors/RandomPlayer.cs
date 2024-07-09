
namespace RoshamboRockPaperScissors;

public class RandomPlayer : Player
{
    public override Roshambo GenerateRoshambo()
    {
        Random rand = new Random();
        int randNumber = rand.Next(0, 3);
        return (Roshambo)randNumber;
    }
}
