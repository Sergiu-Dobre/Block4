using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTheSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public Transform[] fishPrefabs;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   for (int i = 0;i>= 5; i++) {
            if (active)
            {
                int randomFish = Random.Range(0, fishPrefabs.Length);
                int randomSpawnPoint = Random.Range(0, spawnPoints.Length);

                Instantiate(fishPrefabs[0], spawnPoints[randomSpawnPoint].position, transform.rotation);
                active = false;
            } 
        }
    }
}
