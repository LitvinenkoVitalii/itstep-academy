using System;

namespace AbstractShapes
{
    class Ellipse : Shape, IShape, IDrawable
    {

        public Ellipse(int x, int y, int width, int height, ConsoleColor color) : base(x, y, width, height, color)
        {
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.Write("        \u2584\u2584\n");
            Console.Write("      \u2584\u2588\u2588\u2588\u2588\u2584\n");
            Console.Write("      \u2588\u2588\u2588\u2588\u2588\u2588\n");
            Console.Write("      \u2580\u2588\u2588\u2588\u2588\u2580\n");
            Console.Write("        \u2580\u2580\n");
            Console.ResetColor();
        }

    }
}
