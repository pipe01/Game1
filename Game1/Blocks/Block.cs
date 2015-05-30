using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Blocks
{
    abstract class Block
    {
        public abstract string getBlockID();
        public abstract int getBlockNumID();

        public static Block getFromNumID(int id)
        {
            switch (id)
            {
                case 0:
                    return new BlockAir();
                case 1:
                    return new BlockGrass();
                case 2:
                    return new BlockDirt();
                case 3:
                    return new BlockStone();
                default:
                    return null;
            }
        }
    }
}
