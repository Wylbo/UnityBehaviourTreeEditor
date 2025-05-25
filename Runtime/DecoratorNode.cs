using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wylbo
{
    public abstract class DecoratorNode : Node
    {

        [SerializeReference]
        [HideInInspector]
        public Node child;
    }
}
