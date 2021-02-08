using System;
using Raylib_cs;

namespace AIE__Week2_05_GameSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSettings gs = new GameSettings(800, 600, "GameSettingsProgram");

            Raylib.InitWindow(gs.windowWidth, gs.windowHeight, gs.windowTitle);

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
