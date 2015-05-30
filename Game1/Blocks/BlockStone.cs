using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Blocks
{
    class BlockStone : Block
    {
        public override string getBlockID() { return "stone"; }
        public override int getBlockNumID() { return 3; }
    }
}
