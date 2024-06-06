
namespace Circle_Objects;

public class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateDiameter()
    {
        return radius * 2.0;
    }
    public double CalculateCircumference()
    {
        return 2.0 * Math.PI * radius;
    }

    public double CalculateArea()
    {
        return radius * radius * Math.PI;
    }

    public void Grow()
    {
        radius = radius * 2.0;
    }

    public double GetRadius()
    {
        return radius;
    }

}
