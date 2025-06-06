using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wylbo
{
    [System.Serializable]
    public class RandomFailure : ActionNode
    {

        [Range(0, 1)]
        [Tooltip("Percentage chance of failure")] public float chanceOfFailure = 0.5f;

        protected override void OnStart()
        {
        }

        protected override void OnStop()
        {
        }

        protected override State OnUpdate()
        {
            float value = Random.value;
            if (value <= chanceOfFailure)
            {
                return State.Failure;
            }
            return State.Success;
        }
    }
}