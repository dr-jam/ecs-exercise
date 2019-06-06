using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using Unity.Transforms;

namespace Assignment.ECS
{
    public class MovementSystem : JobComponentSystem
    {
        struct MovementJob : IJobForEach<Translation>
        {
            public float deltaTime;
            // Create a new joob here. Should be similar to previous Movementjob
            public void Execute (ref Translation translation)
            {
            }
        }
        protected override JobHandle OnUpdate (JobHandle inputDeps)
        {
        // Fill in the rest of OnUpdate. Use resources for help.
        }
    }
}