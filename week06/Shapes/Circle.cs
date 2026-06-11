using System.Formats.Asn1;

public class Circle : Shape
{
    private float _radius;
    public Circle(string color, float radius) : base (color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        float area = 3.14f * _radius * _radius;
        return area;
    }
}