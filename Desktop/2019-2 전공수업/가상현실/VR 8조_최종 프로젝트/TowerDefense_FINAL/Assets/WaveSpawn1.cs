using UnityEngine;
using System.Collections;

public class WaveSpawn1 : MonoBehaviour
{
    public GameObject Enemy;
    public float MIN_TIME = 1;
    public float MAX_TIME = 5;
    public GameObject clone;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("CreateGoblin");
    }

    IEnumerator CreateGoblin()
    {
        while (Application.isPlaying)
        {
            float createTime = Random.Range(MIN_TIME, MAX_TIME);
            yield return new WaitForSeconds(createTime);

            clone = Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }
}
