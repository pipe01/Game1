using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.Blocks;
using Game1.EntityF;
using Game1.EntityF.Player;

namespace Game1
{
    abstract class World
    {

#region "General"
        public abstract float getWorldGravity();
        public abstract void loadWorld();
        public abstract void loadWorld();
        public abstract WorldRenderer getRenderer();

        public int getWorldLength()
        {
            return getBlockMap().GetLength(0) + 1;
        }
#endregion

#region "Blocks"
        public abstract Block[,] getBlockMap();
        
        public Block getBlockAt(int x, int y)
        {
            try
            {
                return getBlockMap()[x, y];
            }
            catch (Exception)
            {
                return new BlockAir();
            }
        }

        public bool testBlockAt(Block target, int x, int y)
        {
            if (getBlockAt(x, y) == target)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
#endregion

#region "Entities"
        public abstract List<Entity> getEntityMap();

        public Entity getEntityAt(Vector2 pos)
        {
            foreach (Entity item in getEntityMap())
            {
                if (item.getPosition() == pos)
                {
                    return item;
                }
            }
            return null;
        }
#endregion
    }

    class WorldRenderer
    {
        private World world;

        public WorldRenderer(World world)
        {
            this.world = world;
        }

        public void render()
        {
            Block block;
            for (int x = 0; x < world.getWorldLength(); x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    block = world.getBlockAt(x, y);
                    if (block != null && block.getBlockID() != "air")
                    {
                        Global.spriteBatch.Draw(Global.resource.getTexture(block.getBlockID()),
                            new Rectangle(new Point(x * 32, y * 32), new Point(32, 32)), Color.White);
                    }
                }
            }
        }

        public void preRender()
        {
            Block block;
            for (int x = 0; x < world.getWorldLength(); x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    block = world.getBlockAt(x, y);
                    if (block != null && block.getBlockID() != "air")
                    {
                        Global.resource.addIfDoesntExist(block.getBlockID(),
                            Global.content.Load<Texture2D>("Block/" + block.getBlockID()));
                    }
                    
                }
            }
        }
    }
}
