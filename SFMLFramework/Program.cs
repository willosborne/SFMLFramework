using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;
using SFMLFramework.ExampleGame;

namespace SFMLFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRoot game = new GameRoot();
            
            SF.Initialize(640, 480, "SFML Framework test");            
            SF.SetGame(game);
            SF.Start();
        }
    }
}
