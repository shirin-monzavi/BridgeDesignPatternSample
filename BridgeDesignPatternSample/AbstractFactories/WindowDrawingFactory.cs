using BridgeDesignPatternSample.Implementors;

namespace BridgeDesignPatternSample.AbstractFactories;
public class WindowDrawingFactory : IDrawingFactory
{
    public IDrawingImp CreateDrawing()
    {
        return new WindowsDrawing();
    }
}
