﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Components {
    class Collidable : Component {
        public Colliders.Collider collider;
        public float mass;
    }
}
