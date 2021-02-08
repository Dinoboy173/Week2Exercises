using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace AIE_Week2_06_SpriteClass
{
    class Sprite
    {
        public Texture2D texture;
        public Vector2 pos;
        public Vector2 size;
        public Vector2 origin;
        public float rotation;
        public Color color;
        public Vector2 velocity = new Vector2();

        public Sprite(Texture2D texture, Vector2 pos, Vector2 size)
        {
            this.texture = texture;
            this.pos = pos;
            this.size = size;

            color = Color.WHITE;
            rotation = 0.0f;
            origin = new Vector2(0.5f, 0.5f);
        }

        public void Update()
        {
            pos += velocity;
        }

        public void Draw()
        {
            Raylib.DrawTexturePro(
                texture,
                new Rectangle(0, 0, texture.width, texture.height),
                new Rectangle(pos.X, pos.Y, size.X, size.Y),
                new Vector2(size.X * origin.X, size.Y * origin.Y),
                rotation,
                color
             );
        }

    }
}