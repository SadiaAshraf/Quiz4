using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject BombPrefab;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 2);
        InvokeRepeating("SpawnEnemyBomb", 1, 3);

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Vector2 SpawnEm = new Vector2(Random.Range(-11, 11), Random.Range(3, 5));
        Instantiate(EnemyPrefab, SpawnEm, Quaternion.identity);

       // Instantiate(EnemyPrefab);
    }
    void SpawnEnemyBomb()
    {
        Instantiate(BombPrefab, Vector2.down, Quaternion.identity);
    }

}
