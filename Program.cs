﻿

using System;
using Tao.Sdl;

namespace MyGame
{

    class Program
    {
                    
        static IntPtr image = Engine.LoadImage("assets/fondo.png");
        static IntPtr player = Engine.LoadImage("assets/player.png");


        static void Main(string[] args)
        {
            Engine.Initialize();
            

            while (true)
            {
                Update();
                
                Engine.Clear();

                Engine.Draw(image, 0, 0);
                
                Engine.Show();

                Sdl.SDL_Delay(20);
            }
        }


        private static void Update()
        {
            if (Engine.KeyPress(Engine.KEY_LEFT)) {  }

            if (Engine.KeyPress(Engine.KEY_RIGHT)) {  }

            if (Engine.KeyPress(Engine.KEY_UP)) { }

            if (Engine.KeyPress(Engine.KEY_DOWN)) {  }

            if (Engine.KeyPress(Engine.KEY_ESC)) {  }

        }

    }

}
