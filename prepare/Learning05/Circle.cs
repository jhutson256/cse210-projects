public class Circle : Shape
{
    private double _jphRadius;

    public Circle(string jph_color, double jph_radius) : base (jph_color)
    {
        _jphRadius = jph_radius;
    }

    public override double GetArea()
    {
        return _jphRadius * _jphRadius * Math.PI;
    }
}