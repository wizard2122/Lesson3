using System;

public class HexMazeFormFactory : MazeFormFactory
{
    public override MazeGridForm Get(MazeFormType form)
    {
        switch (form)
        {
            case MazeFormType.Rectangle:
                return new RectangleHexMazeForm();

            case MazeFormType.Ellipse:
                return new EllipseHexMazeForm();

            case MazeFormType.Triangle:
                return new TriangleHexMazeForm();
        }

        throw new ArgumentException($"No maze form for {form}");
    }
}
