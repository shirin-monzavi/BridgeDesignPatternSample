using BridgeDesignPatternSample.Implementors;

namespace BridgeDesignPatternSample.AbstractFactories;
public interface IDrawingFactory
{
    IDrawingImp CreateDrawing();
}
