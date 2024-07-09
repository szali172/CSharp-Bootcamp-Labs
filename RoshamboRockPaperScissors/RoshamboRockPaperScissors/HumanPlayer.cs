
namespace RoshamboRockPaperScissors;


public class HumanPlayer : Player
{
    public string Name { get; set; }

    public HumanPlayer(string Name)
    {
        this.Name = Name;
    }

    public override Roshambo GenerateRoshambo()
    {
        return Value;
    }
}
