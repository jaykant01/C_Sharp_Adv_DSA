using System.Collections.Generic;

namespace Stack;

interface IDrawingAction
{
    void Execute();
    void Undo();
}


public class DrawLineAction : IDrawingAction
{
    public void Execute()
    {
        Console.WriteLine("Line drawn.");
    }

    public void Undo()
    {
        Console.WriteLine("Line removed.");
    }
}

class DrawCircleAction : IDrawingAction
{
    public void Execute()
    {
        Console.WriteLine("Circle drawn.");
    }

    public void Undo()
    {
        Console.WriteLine("Circle removed.");
    }
}

class EraseAction : IDrawingAction
{
    public void Execute()
    {
        Console.WriteLine("Erased drawing.");
    }

    public void Undo()
    {
        Console.WriteLine("Erase undone.");
    }
}

class DrawingApp
{
    private Stack<IDrawingAction> undoStack = new Stack<IDrawingAction>();

    public void PerformAction(IDrawingAction action)
    {
        action.Execute();
        undoStack.Push(action);
    }

    public void Undo()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }

        IDrawingAction lastAction = undoStack.Pop();
        lastAction.Undo();
    }
}
