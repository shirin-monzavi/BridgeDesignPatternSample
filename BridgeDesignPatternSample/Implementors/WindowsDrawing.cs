namespace BridgeDesignPatternSample.Implementors;

public class WindowsDrawing : IDrawingImp
{
    public void DrawCircle(int x, int y, int radius)
    {
        Console.WriteLine($"[Windows] Drawing Circle at ({x},{y}) with radius {radius}");
    }
}
