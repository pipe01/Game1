using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Blocks
{
    class BlockDirt : Block
    {
        public override string getBlockID() { return "dirt"; }
        public override int getBlockNumID() { return 2; }
    }
}
