public class Rectangle : Shape
{
    private double _jphLength;
    private double _jphWidth;

    public Rectangle(string jph_color, double jph_length, double jph_width) : base (jph_color)
    {
        _jphLength = jph_length;
        _jphWidth = jph_width;
    }

    public override double GetArea()
    {
        return _jphLength * _jphWidth;
    }
}