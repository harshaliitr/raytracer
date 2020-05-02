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
            Vec3 lower_left_corner = new Vec3(-2.0F, -1.0F, -1.0F);
            Vec3 horizontal = new Vec3(4.0F, 0.0F, 0.0F);
            Vec3 vertical = new Vec3(0.0F, 2.0F, 0.0F);
            Vec3 origin = new Vec3(0.0F, 0.0F, 0.0F);
            Console.Write($"P3\n{image_width} {image_height}\n255\n");
            for (int j = image_height - 1; j >= 0; --j)
            {
                for (int i = 0; i < image_width; ++i)
                {
                    float u = (float)i / image_width;
                    float v = (float)j / image_height;
                    Ray r = new Ray(origin, lower_left_corner + u * horizontal + v * vertical);
                    Vec3 color = Ray_color(r);
                    color.Write_Color();
                }
            }
        }

        private Vec3 Ray_color(Ray r)
        {
            var v1 = new Vec3(1.0F, 1.0F, 1.0F);
            var v2 = new Vec3(0.5F, 0.7F, 1.0F);
            Vec3 unit_direction = Vec3.Unit_vector(r.Direction());
            var t = 0.5F * (unit_direction.Y + 1.0F);
            return (1 - t) * v1 + t * v2;
        }
    }
}
