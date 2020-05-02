using System;
// using System.Runtime.Intrinsics;
using System.Numerics;

namespace ray_tracing
{
    public class Vec3
    {
        private readonly Vector3 _vector;

        public Vec3()
        {
            _vector.X = 0;
            _vector.Y = 0;
            _vector.Z = 0;
        }
        public Vec3(float e0, float e1, float e2)
        {
            _vector.X = e0;
            _vector.Y = e1;
            _vector.Z = e2;
        }

        public float X { get => _vector.X; }
        public float Y { get => _vector.Y; }
        public float Z { get => _vector.Z; }

        public void Write_Color()
        {
            string outString = $"{(int)(255.999 * _vector.X)} {(int)(255.999 * _vector.Y)} {(int)(255.999 * _vector.Z)}";
            Console.WriteLine(outString);
        }

        public float Length() => _vector.Length();
        public float Length_squared() => _vector.LengthSquared();

        public static Vec3 Unit_vector(Vec3 v) => v/v.Length();

        public static Vec3 operator *(float t, Vec3 vector)
        {
            return new Vec3(t * vector.X, t * vector.Y, t * vector.Z);
        }
        public static Vec3 operator +(Vec3 a, Vec3 b)
        {
            return new Vec3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vec3 operator /(Vec3 a, float t)
        {
            return (1/t) * a;
        }
    }
}
