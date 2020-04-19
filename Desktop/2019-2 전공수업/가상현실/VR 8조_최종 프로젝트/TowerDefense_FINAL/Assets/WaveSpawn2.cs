using UnityEngine;
using System.Collections;

public class WaveSpawn2 : MonoBehaviour {

    public GameObject enemy;
    public float MIN_TIME = 1;
    public float MAX_TIME = 5;
    public GameObject clone;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("CreateSuperGoblin");
    }

    IEnumerator CreateSuperGoblin()
    {
        while (Application.isPlaying)
        {
            float createTime = Random.Range(MIN_TIME, MAX_TIME);
            yield return new WaitForSeconds(createTime);
          
                clone = Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
