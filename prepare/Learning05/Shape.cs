public abstract class Shape
{
    private string _jphColor;

    public Shape(string jph_color)
    {
        _jphColor = jph_color;
    }

    public string GetColor()
    {
        return _jphColor;
    }

    public void SetColor(string jph_color)
    {
        _jphColor = jph_color;
    }

    public abstract double GetArea();
}