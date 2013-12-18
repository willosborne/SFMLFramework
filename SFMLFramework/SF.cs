using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace SFMLFramework
{
    static class SF
    {
        public static float DeltaTime;
        static Game Game;

        static RenderWindow Window;
        static Stopwatch DeltaTimer;

        static bool Paused = true;

        public static void SetGame(Game game)
        {
            Game = game;
            Game.Window = Window;
            Game.Initialize();
            Paused = false;
        }

        private static void OnClose(object sender, EventArgs e)
        {
            Window.Close();
        }

        public static void Initialize(uint width, uint height, string title)
        {
            Window = new RenderWindow(new VideoMode(width, height), title);
            Window.Closed += new EventHandler(OnClose);

            DeltaTimer = Stopwatch.StartNew();
            if (Game == null)
               Game = Game.None;            
        }
        public static void Start()
        {
            while (Window.IsOpen() && !Paused)
            {
                Update();
                Draw();

                Window.Display();                               
            }
        }

        private static void Update()
        {
            DeltaTime = (float)DeltaTimer.Elapsed.TotalSeconds;
            DeltaTimer.Restart();

            Window.DispatchEvents();
            Game.Update();
        }

        private static void Draw()
        {

            Window.Clear(Color.Magenta);

            Game.Draw();
        }
    }
}
