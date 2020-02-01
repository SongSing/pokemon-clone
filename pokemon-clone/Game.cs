using SFML;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace pokemon_clone
{
    class Game
    {

        public static Vector2i MousePosition => Mouse.GetPosition(Window);
        public static Vector2f MousePositionf => Utils.Vi2f(Mouse.GetPosition(Window));

        public static RenderWindow Window;
        private float framerate = 1 / 60.0f;
        private float counter = 0.0f;
        private Clock clock;
        private Vector2f _viewSize;
        private Battle _battle;

        public Game() : this(800, 600) { }

        public Game(uint width, uint height)
        {
            RenderWindow window = new RenderWindow(new VideoMode(width, height), "TOU8HOU JAM 5 BABEY", Styles.Close);
            window.SetVerticalSyncEnabled(true);
            window.SetActive();
            Window = window;

            _viewSize = new Vector2f(width, height);
            View v = new View(new FloatRect(new Vector2f(0, 0), _viewSize));
            Window.SetView(v);

            //Window.Resized += (sender, eeee) =>
            //{
            //    Window.SetView(this.CalcView());
            //};

            AKS.InitializeWindow(window);

            this.clock = new Clock();

            window.Closed += (sender, e) =>
            {
                window.Close();
            };

            window.KeyPressed += (sender, e) =>
            {
                if (e.Code == Keyboard.Key.Escape)
                {
                    window.Close();
                }
            };

            // /////////////////////////////////////////////// //

            _battle = new Battle();

            this.Run();
        }

        protected void Run()
        {
            while (Window.IsOpen)
            {
                AKS.Update();

                float delta = this.clock.Restart().AsSeconds();
                this.counter += delta;
                Window.DispatchEvents();

                if (this.counter >= this.framerate)
                {
                    int times = (int)(this.counter / this.framerate);
                    this.counter %= this.framerate;

                    for (int i = 0; i < times; i++)
                    {
                        this.Update(this.framerate);
                    }
                }

                this.Draw(Window);
            }
        }

        protected void Update(float delta)
        {
            _battle.Update(delta);
        }

        protected void Draw(RenderWindow window)
        {
            window.Clear(Color.White);
            _battle.Draw(window);
            window.Display();
        }
    }
}
