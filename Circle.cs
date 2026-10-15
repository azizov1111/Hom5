
public class Circle
{
    private double radius;
    private double PI = 3.14159;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle()
    {
        radius = 0.0;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public double GetArea()
    {
        return PI * radius * radius;
    }

    public double GetDiameter()
    {
        return radius * 2;
    }

    public double GetCircumference()
    {
        return 2 * PI * radius;
    }
}