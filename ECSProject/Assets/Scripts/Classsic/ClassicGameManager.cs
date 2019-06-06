using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace Assignment.ECS
{
    public class ClassicGameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject myPrefab;
        private int count = 0;
        private int amount = 1500;
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                GameObjectSpawn();
            }
        }
        public void GameObjectSpawn()
        {
            for (int i = 0; i < amount; i++)
            {
                Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(-100, 100), 0, 0), Quaternion.identity);
            }
            count += amount;
            Debug.Log(count);
        }
    }

}
