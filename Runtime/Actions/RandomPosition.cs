using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wylbo
{
    [System.Serializable]
    public class RandomPosition : ActionNode
    {

        [Tooltip("Minimum bounds to generate point")]
        public Vector3 min = Vector2.one * -10;

        [Tooltip("Maximum bounds to generate point")]
        public Vector3 max = Vector2.one * 10;

        [Tooltip("Blackboard key to write the result to")]
        public NodeProperty<Vector3> result;

        protected override void OnStart()
        {
        }

        protected override void OnStop()
        {
        }

        protected override State OnUpdate()
        {
            Vector3 pos = new Vector3();
            pos.x = Random.Range(min.x, max.x);
            pos.y = Random.Range(min.y, max.y);
            pos.z = Random.Range(min.z, max.z);
            result.Value = pos;
            return State.Success;
        }
    }
}
