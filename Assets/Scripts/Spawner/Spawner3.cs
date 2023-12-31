using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnTime = 14f;
    public float maxSpawnTime = 25f;
    public GameManagerControl gameManager;

    void Start()
    {
        InvokeRepeating("Spawner", 25, Random.Range(minSpawnTime, maxSpawnTime));
    }

    void Spawner()
    {
        GameObject randomEnemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject zombie = Instantiate(randomEnemy, transform.position, transform.rotation);
        zombie.GetComponent<HerenciaZombies>().gameManager = gameManager;
        InvokeRepeating("Spawner", 25, Random.Range(minSpawnTime, maxSpawnTime));
    }
}
