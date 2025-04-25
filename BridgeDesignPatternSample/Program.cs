using BridgeDesignPatternSample.AbstractFactories;
using BridgeDesignPatternSample.Abstractions;

IDrawingFactory windowsFactory = new WindowDrawingFactory();

Shape circle = new Circle(1, 1, 1, windowsFactory.CreateDrawing());

circle.Draw();

