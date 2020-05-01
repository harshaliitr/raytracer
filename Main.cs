using System;

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
                    var r = (double)i / image_width;
                    var g = (double)j / image_height;
                    var b = 0.2;
                    int ir = (int)(255.999 * r);
                    int ig = (int)(255.999 * g);
                    int ib = (int)(255.999 * b);
                    Console.Write($"{ir} {ig} {ib}\n");
                }
            }
        }
    }
}
