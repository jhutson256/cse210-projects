public class Square : Shape
{
    private double _jphSide;

    public Square(string jph_color, double jph_side) : base (jph_color)
    {
        _jphSide = jph_side;
    }

    public override double GetArea()
    {
        return _jphSide * _jphSide;
    }
}