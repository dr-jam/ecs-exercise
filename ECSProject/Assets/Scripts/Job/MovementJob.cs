using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace Assignment.JobSystem
{
    public struct MovementJob : IJobParallelForTransform
    {
        public float deltaTime;

        public void Execute (int index, TransformAccess transform)
        {
            // Write code here. It should be similar to the classical Movement.
        }
    }
}
