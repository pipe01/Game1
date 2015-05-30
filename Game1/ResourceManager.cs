using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class ResourceManager
    {
        private Dictionary<String, Texture2D> textures = new Dictionary<string, Texture2D>();

        public ResourceManager() { }

        public void addTexture(string key, Texture2D texture)
        {
            textures.Add(key, texture);
        }

        public void addIfDoesntExist(string key, Texture2D texture)
        {
            if (!textures.ContainsKey(key))
            {
                addTexture(key, texture);
            }
        }

        public Texture2D getTexture(string key)
        {
            return textures[key];
        }
    }
}
