using System;
using System.Collections.Generic;
using System.Text;

namespace AIE__Week2_05_GameSettings
{
    class GameSettings
    {
        public int windowWidth;
        public int windowHeight;
        public string windowTitle;

        public GameSettings(int width, int height, string title)
        {
            windowWidth = width;
            windowHeight = height;
            windowTitle = title;
        }
    }
}