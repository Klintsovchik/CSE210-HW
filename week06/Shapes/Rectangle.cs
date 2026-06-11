public class Rectangle : Shape
{
    private float _width;
    private float _length;

    public Rectangle(string color, float width, float length) : base (color)
    {
        _width = width;
        _length = length;
    }
    public override float GetArea()
    {
        float area = _width * _length;
        return area;
    }
}