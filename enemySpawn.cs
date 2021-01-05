using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    public static bool spawnAllowed;
    int randomSpawnPoint, randomMonster;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAEnemy", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAEnemy()
    {
        if(spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomMonster], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
        }
    }
}
