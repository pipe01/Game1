using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Blocks
{
    class BlockAir : Block
    {
        public override string getBlockID() { return "air"; }
        public override int getBlockNumID() { return 0; }
    }
}
