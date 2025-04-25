using BridgeDesignPatternSample.Implementors;

namespace BridgeDesignPatternSample.Abstractions;

public class Circle : Shape
{
    #region Field
    private readonly int _x, _y, _radius;
    #endregion

    public Circle(int x, int y, int radius,IDrawingImp drawingImp) : base(drawingImp)
    {
        _x = x;
        _y = y;
        _radius = radius;
    }

    public override void Draw()
    {
        _drawingImp.DrawCircle(_x, _y, _radius);
    }
}
