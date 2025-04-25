using BridgeDesignPatternSample.AbstractFactories;
using BridgeDesignPatternSample.Implementors;

namespace BridgeDesignPatternSample.Abstractions;

public abstract class Shape
{
    protected IDrawingImp _drawingImp;

    protected Shape(IDrawingImp drawingImp)
    {
        _drawingImp = drawingImp;
    }

    public abstract void Draw();
}
