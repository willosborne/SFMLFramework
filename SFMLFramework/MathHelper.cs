using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFMLFramework
{
    static class MathHelper
    {
        public const float Pi = 3.141592654f;
        public const float TwoPi = Pi * 2;
        public const float PiOver2 = Pi / 2;
        public const float PiOver4 = Pi / 4;


        public static T Clamp<T>(T value, T min, T max)
            where T : IComparable<T>
        {
            T result = value;
            if (result.CompareTo(max) > 0)
                result = max;
            if (result.CompareTo(min) < 0)
                result = min;
            return result;
        }
        public static float ClampAngle(float angle)
        {
            while (angle < 0)
                angle += TwoPi;
            while (angle > TwoPi)
                angle -= TwoPi;
            return angle;
        } 
    }
}
