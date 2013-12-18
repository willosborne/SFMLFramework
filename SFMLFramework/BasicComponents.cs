using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;

namespace SFMLFramework
{
    class Position : Component
    {
        public Vector2f Position;
    }

    class Rotation : Component
    {
        private float rotation;
        public float Rotation
        {
            get
            {
                return rotation;
            }
            set
            {
                rotation = value;
            }
        }
        public void ClampRotation()
        {
            Rotation = MathHelper.ClampAngle(Rotation);
        }
    }
}
