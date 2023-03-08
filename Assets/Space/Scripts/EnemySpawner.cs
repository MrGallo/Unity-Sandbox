using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyReference;

    private GameObject spawnedEnemy;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, enemyReference.Length);

            spawnedEnemy = Instantiate(enemyReference[randomIndex]);

            Vector3 position = gameObject.transform.position;
            position.x = Random.Range(position.x - 10, position.x + 10);
            spawnedEnemy.transform.position = position;
        }
    }
}
