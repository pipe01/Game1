using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    class WorldManager
    {
        public WorldManager()
        {

        }

        private Dictionary<string,World> dic = new Dictionary<string,World>();

        public bool loadWorld(World world, string key)
        {
            if(!dic.ContainsKey(key))
            {
                dic.Add(key, world);
                dic[key].loadWorld();
                return true;
            }
            return false;
        }

        public World getWorld(string key)
        {
            if(dic.ContainsKey(key))
            {
                return dic[key];
            }
            return null;
        }

        public bool unloadWorld(string key)
        {
            if (dic.ContainsKey(key))
            {
                dic.Remove(key);
                return true;
            }
            return false;
        }

        public bool unloadAll()
        {
            foreach (string key in dic.Keys)
            {
                dic.Remove(key);
            }
            return true;
        }
    }
}
