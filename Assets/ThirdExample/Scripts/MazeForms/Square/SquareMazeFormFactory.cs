using System;

public class SquareMazeFormFactory : MazeFormFactory
{
    public override MazeGridForm Get(MazeFormType form)
    {
        switch (form)
        {
            case MazeFormType.Rectangle:
                return new RectangleSquareMazeForm();

            case MazeFormType.Ellipse:
                return new EllipseSquareMazeForm();

            case MazeFormType.Triangle:
                return new TriangleSquareMazeForm();
        }

        throw new ArgumentException(nameof(form));
    }
}
