using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.EntityF
{
    abstract class Entity
    {
        public abstract string getID();

        public abstract Texture2D getFrame();

        public abstract Vector2 getPosition();

        public abstract float getWeight();

        public abstract void update();

        public abstract void teleport(Vector2 to);
        public abstract void move(Vector2 amount);

        public abstract void addForce(Vector2 amount);
    }
}
