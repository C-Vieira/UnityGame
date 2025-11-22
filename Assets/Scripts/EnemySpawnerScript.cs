using System.Collections;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public BoxCollider2D spawnerArea;
    public GameObject enemyBasic;
    public float enemyBasicTimeInterval = 3.0f;
    public GameObject enemyMedium;
    public float enemyMediumTimeInterval = 8.0f;

    void Start()
    {
        StartCoroutine(spawnEnemy(enemyBasicTimeInterval, enemyBasic));
        StartCoroutine(spawnEnemy(enemyMediumTimeInterval, enemyMedium));
    }

    private IEnumerator spawnEnemy(float timeInterval, GameObject enemy)
    {
        // Wait between spawns
        yield return new WaitForSeconds(timeInterval);
        // Instatiate a new enemy prefab with a random x offset
        Instantiate(
            enemy,
            new Vector3(
                Random.Range(transform.position.x - (spawnerArea.size.x/2), transform.position.x + (spawnerArea.size.x/2)),
                transform.position.y,
                0.0f),
                Quaternion.identity);
        // Loop
        StartCoroutine(spawnEnemy(timeInterval, enemy));
    }

}
