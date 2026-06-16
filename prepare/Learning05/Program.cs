using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> jph_shapes = new List<Shape>();

        Square jph_shape1 = new Square("Red", 3);
        jph_shapes.Add(jph_shape1);

        Rectangle jph_shape2 = new Rectangle("Blue", 4, 5);
        jph_shapes.Add(jph_shape2);

        Circle jph_shape3 = new Circle("Green", 6);
        jph_shapes.Add(jph_shape3);

        foreach (Shape jph_shape in jph_shapes)
        {
            string jph_color = jph_shape.GetColor();
            double jph_area = jph_shape.GetArea();

            Console.WriteLine($"The {jph_color} shape has an area of {jph_area}.");
        }
    }
}