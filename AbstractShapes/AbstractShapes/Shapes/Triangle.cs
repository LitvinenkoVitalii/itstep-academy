using System;

namespace AbstractShapes
{
    class Triangle : Shape, IShape, IDrawable
    {
        public Triangle(int x, int y, int width, int height, ConsoleColor color) : base(x, y, width, height, color)
        {
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.Write("        \u2584\n");
            Console.Write("      \u2584\u2588\u2588\u2588\u2584\n");
            Console.Write("    \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2584\n");
            Console.Write("  \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2584\n");
            Console.Write("\u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2584\n");
            Console.ResetColor();
        }

    }
}
