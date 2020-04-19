using UnityEngine;
using System.Collections;
public class WaveSpawnN : MonoBehaviour
{

    public int WaveSize;
    public GameObject EnemyPrefab;
    public float EnemyInterval;
    public Transform spawnPoint;
    public float startTime;
    public Transform[] WayPoints;
    int enemyCount = 0;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", startTime, EnemyInterval);
    }

    void Update()
    {
        if (enemyCount == WaveSize)
        {
            CancelInvoke("SpawnEnemy");
        }
    }

    void SpawnEnemy()
    {
        enemyCount++;
        GameObject enemy = NewMethod4();
        NewMethod1(enemy);

    }

    private GameObject NewMethod4()
    {
        return GameObject.Instantiate(EnemyPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
    }

    private void NewMethod1(GameObject enemy)
    {
        NewMethod3(enemy);
    }

    private void NewMethod3(GameObject enemy)
    {
        NewMethod2(enemy);
    }

    private void NewMethod2(GameObject enemy)
    {
        NewMethod(enemy).waypoints = WayPoints;
    }

    private static Enemy NewMethod(GameObject enemy)
    {
        return enemy.GetComponent<Enemy>();
    }
}
