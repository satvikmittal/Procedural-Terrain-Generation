
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float radius = 100f;
    public int enemiesSpawned = 0;

    public float waitTime = 2.50f;

    public float spawnCheckRadius = 20f;

    public EnemyStruct[] enemies;

    public int maxEnemies = 4;

    Transform player;

    [HideInInspector]
    public List<GameObject> SpawnedEnemies = new List<GameObject>();

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {

        if (Vector3.Distance(player.position, transform.position) <= radius)
        {
            StartCoroutine(SpawnEnemy());
        }
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            if (enemiesSpawned < maxEnemies)
            {
                if (enemiesSpawned >= maxEnemies)
                {
                    break;
                }

                Vector3 spawnPos = transform.position;
                spawnPos += Random.insideUnitSphere.normalized * radius;

                if (!Physics.CheckSphere(spawnPos, spawnCheckRadius))
                {
                    GameObject generated = Instantiate(enemies[Random.Range(0, enemies.Length)].EnemyPrefab, spawnPos, Quaternion.identity);
                    SpawnedEnemies.Add(generated);

                    //yield return new WaitForSeconds(waitTime);

                    enemiesSpawned++;
                }
            }
            yield return null;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, spawnCheckRadius);
    }
}

[System.Serializable]
public struct EnemyStruct
{
    public string name;
    public GameObject EnemyPrefab;
    public float value;
}