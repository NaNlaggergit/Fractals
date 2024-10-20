using System;

namespace Fractals;

internal static class DragonFractalTask
{
    public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
    {
        var random = new Random(seed);
        double x = 1;
        double y = 0;
        pixels.SetPixel(x, y);
        for (int i = 0; i < iterationsCount-1; i++)
        {
            int r=random.Next(2);
            if(r == 0)
            {
                double angle = 45 * (Math.PI / 180);
                double x1 = (x * Math.Cos(angle) - y * Math.Sin(angle)) / Math.Sqrt(2);
                double y1 = (x * Math.Sin(angle) + y * Math.Cos(angle)) / Math.Sqrt(2);
                x = x1;
                y = y1;
            }
            if (r == 1)
            {
                double angle = 135 * (Math.PI / 180);
                double x1 = (x * Math.Cos(angle) - y * Math.Sin(angle)) / Math.Sqrt(2)+1;
                double y1 = (x * Math.Sin(angle) + y * Math.Cos(angle)) / Math.Sqrt(2);
                x = x1;
                y = y1;
            }
            pixels.SetPixel(x, y);
        }
    }
}