using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csNgin.engine
{
    public class vec2
    {
        public float x;
        public float y;

        public vec2(float _x = 0, float _y = 0) { x = _x; y = _y; }

        public override string ToString()
        {
            return $"({x.ToString()} ; {y.ToString()})";
        }
    }

    public static class transform
    {
        public static vec2 subtract(vec2 _a, vec2 _b)
        {
            return new vec2(_a.x - _b.x, _a.y - _b.y);
        }

        public static vec2 multiplication(vec2 _a, vec2 _b)
        {
            return new vec2(_a.x * _b.x, _a.y * _b.y);
        }
    }
}
