using System;

public interface Widget
{
    void draw();
}


public class TextField : Widget
{
    public void draw()
    {
        Console.WriteLine("TextField.draw() called.");
    }
}

public abstract class Decorator : Widget
{
    private Widget _component;

    public Decorator(Widget component)
    {
        _component = component;
    }

    public virtual void draw()
    {
        _component.draw();
    }
}

public class BorderDecoratorA : Decorator
{
    public BorderDecorator(Widget component) : base(component)
    {
    }

    public override void draw()
    {
        base.draw();
        Console.WriteLine("BorderDecorator.Operation() called.");
    }
}

public class ScrollDecorator : Decorator
{
    public ScrollDecoratorB(Widget component) : base(component)
    {
    }

    public override void draw()
    {
        base.draw();
        Console.WriteLine("ScrollDecorator.Operation() called.");
    }
}
