using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.EntityF.Player
{
    class EntityPlayer : Entity
    {
        private Vector2 pos = new Vector2();
        private Vector2 blockPos = new Vector2();
        private Vector2 momentum = new Vector2();

        private World containerWorld;

        public EntityPlayer(World container)
        {
            this.containerWorld = container;
        }

        public override string getID()
        {
            return "Player";
        }

        #region "Logic"
        public override Vector2 getPosition()
        {
            return this.pos;
        }
        public override void addForce(Vector2 amount)
        {
            this.momentum += amount;
        }
        public override void teleport(Vector2 to)
        {
            this.pos = to;
        }
        public override void move(Vector2 amount)
        {
            this.pos += amount;
        }

        public override float getWeight() { return 4.0f; }
        public override void update()
        {
            this.pos += this.momentum;
            this.blockPos = new Vector2((int) this.pos.X / 32, (int) this.pos.Y * 32);

            if (this.containerWorld.getBlockAt((int) this.blockPos.X, (int) this.blockPos.Y - 1)
                .getBlockNumID() != 0) {
                    this.momentum = Vector2.Zero;
            }

            this.momentum -= new Vector2(2.0f, this.containerWorld.getWorldGravity() * this.getWeight());
        }
        #endregion

        public override Texture2D getFrame()
        {
            throw new NotImplementedException();
        }

    }
}
