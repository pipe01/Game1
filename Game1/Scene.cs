using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    class Scene
    {
        private Camera camera;

        public Scene(Camera cam)
        {
            this.camera = cam;
        }

        public void changeCam(Camera to) { this.camera = to; }

        public Camera getCamera() { return this.camera; }
    }
}
