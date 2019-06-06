using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace Assignment.JobSystem
{
    public class JobGameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject myPrefabJOB;
        private TransformAccessArray transforms;
        private MovementJob moveJob;
        private int count = 0;
        private int amount = 1500;
        private JobHandle moveHandle;

        void OnDisable ()
        {
            moveHandle.Complete();
            transforms.Dispose();
        }

        void Start ()
        {
            transforms = new TransformAccessArray(0, -1);
        }
        void Update ()
        {
            // Complete all existing jobs.
            
            // Spawn Game Objects if space is pressed. Please look at classicGameManger for help.

            // Make a new MovementJob and set it to moveJob

            moveHandle = moveJob.Schedule(transforms);

            JobHandle.ScheduleBatchedJobs();
        }

        public void JobSpawn ()
        {
            // Complete all existing jobs.

            transforms.capacity = transforms.length + amount;
            for (int i = 0; i < amount; i++)
            {
                // Instantiate a game object from the myPredabJOB and store it to a new GameObject obj
                transforms.Add(obj.transform);
            }
            count += amount;
            Debug.Log(count);

            moveJob = new MovementJob();

            JobHandle.ScheduleBatchedJobs();
        }
    }
}