
namespace RoshamboRockPaperScissors;

public abstract class Player
{
    public Roshambo Value { get; set; }

    public abstract Roshambo GenerateRoshambo();
}
