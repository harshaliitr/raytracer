using System;
using System.Numerics;

namespace ray_tracing
{
    public class Main
    {
        public void Run()
        {
            Int16 image_height = 100;
            Int16 image_width = 200;
            Console.Write($"P3\n{image_width} {image_height}\n255\n");
            for (int j = image_height - 1; j >= 0; --j)
            {
                for (int i = 0; i < image_width; ++i)
                {
                    Vec3 color = new Vec3((float)i / image_width, (float)j / image_height, 0.2F);
                    color.Write_Color();
                }
            }
        }
    }
}
