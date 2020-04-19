using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpS : MonoBehaviour
{
    public int EnemyHP2;
    public int hp;

    void Start()
    {
        hp = EnemyHP2;
    }

    public void Dmg(int DMGcount)
    {
        hp -= DMGcount;
    }

    private void Update()
    {
        if ( hp <= 0)
        {
            gameObject.tag = "Dead"; // send it to TowerTrigger to stop the shooting

        }
    }

}
