using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace SFMLFramework.ExampleGame
{
    class GameRoot : Game
    {
        Player player;

        public override void Initialize()
        {
            player = new Player();
            base.Initialize();
        }

        public override void Update()
        {
            player.Update();
            base.Update();
        }

        public override void Draw()
        {
            Window.Clear(Color.White);
            player.Draw(Window);
            
            base.Draw();
        }
    }
}
