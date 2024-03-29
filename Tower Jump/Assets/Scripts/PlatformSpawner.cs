using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject prefab;
    
    //[SerializeField] float timeBetweenSpawn;
    float nextSpawnTime;

    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            SpawnPlatform();

            nextSpawnTime = Time.time + DifficultyManager.instance.platformSpawnRate;
        }
    }

    void SpawnPlatform()
    {
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        GameObject platform = Instantiate(prefab, spawnPoints[randSpawnPoint].position, transform.rotation);
        //Rigidbody2D platformRb2d = platform.GetComponent<Rigidbody2D>();
        //platformRb2d.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        //platformRb2d.velocity = new Vector2(0, -speed);

    }
}
