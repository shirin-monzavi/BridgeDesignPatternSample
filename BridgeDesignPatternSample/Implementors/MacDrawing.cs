namespace BridgeDesignPatternSample.Implementors;

public class MacDrawing : IDrawingImp
{
    public void DrawCircle(int x, int y, int radius)
    {
        Console.WriteLine($"[Mac] Drawing Circle at ({x},{y}) with radius {radius}");
    }
}
