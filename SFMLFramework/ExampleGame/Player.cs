using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Graphics;
using SFML.Window;

namespace SFMLFramework.ExampleGame
{
    class Player
    {
        Sprite sprite;
        Vector2f position;
        Vector2f velocity;

        public Player()
        {
            sprite = new Sprite(new Texture("data\\Lamp.png"));
            position = new Vector2f(0, 0);
            velocity = new Vector2f(50, 0);
        }

        public void Update()
        {
            position += velocity * SF.DeltaTime;
            sprite.Position = position;
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
