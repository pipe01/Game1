using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class Camera
    {
        public readonly Rectangle size;
        public readonly SpriteBatch spriteBatch;
        private int cameraX = 0;
        private World currWorld;

        public Camera(SpriteBatch spriteBatch)
        {
            this.size = new Rectangle(spriteBatch.GraphicsDevice.Viewport.Width,
                                      spriteBatch.GraphicsDevice.Viewport.Height,
                                      0, 0);
            this.spriteBatch = spriteBatch;
        }
        public Camera(Rectangle viewSize, SpriteBatch spriteBatch)
        {
            this.size = viewSize;
            this.spriteBatch = spriteBatch;
        }
        public Camera(Rectangle viewSize, SpriteBatch spriteBatch, World mainWorld)
        {
            this.size = viewSize;
            this.spriteBatch = spriteBatch;
            this.switchWorld(mainWorld);
        }

#region "World"

        public void switchWorld(World to) { currWorld = to; }

        public World getCurrentWorld() { return this.currWorld; }

        public void scroll(int x) { cameraX += x; }

        public void scrollTo(int x) { cameraX = x; }

#endregion
    }
}
