using System.Numerics;
using System;

namespace ray_tracing
{
    public class Ray
    {
        private readonly Vec3 _origin;
        private readonly Vec3 _direction;
        public Ray(Vec3 origin, Vec3 direction)
        {
            _origin = origin;
            _direction = direction;
        }

        public Vec3 Origin() { return _origin; }
        public Vec3 Direction() { return _direction; }

        public Vec3 At(float t) 
        {
            return (_origin + (t*_direction));
        }
    }
}
