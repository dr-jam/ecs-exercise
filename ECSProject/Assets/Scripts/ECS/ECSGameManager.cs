using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;
using Unity.Transforms;

namespace Assignment.ECS
{
    public class ECSGameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject myPrefabECS;
        private float cubeSpeed = 0.1f;
        private int count = 0;
        private int amount = 1500;
        private EntityManager entityManager;
        // Start is called before the first frame update
        void Start ()
        {
            // Get the EntityManager from world and store it to entityManager.
        }

        // Update is called once per frame
        void Update ()
        {
            // Spawn entities when Space is hit. Please look at other GameManagers for help.
        }

        public void ECSSpawn ()
        {
            var prefabConverted = GameObjectConversionUtility.ConvertGameObjectHierarchy(myPrefabECS, World.Active);

            for (int i = 0; i < amount; i++)
            {
                // Instantiate new entity from the prefabConverted.
                // SetComponentData of the new entity with a new position. Please look at resources for help.
            }
            count += amount;
            Debug.Log(count);
        }
    }
}