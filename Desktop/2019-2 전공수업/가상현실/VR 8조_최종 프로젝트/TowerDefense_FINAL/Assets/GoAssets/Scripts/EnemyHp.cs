using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{

    public int EnemyHP;
    public int hp = 0;
    public Slider hpS;

    void Start()
    {
        hp = EnemyHP;
    }

    public void Dmg(int DMGcount)
    {
        hp -= DMGcount;
    }

    private void Update()
    {
        if (hp > 0)
        {
            hpS.value = hp;
        }
        if (hp <= 0)
        {
            gameObject.tag = "Dead"; // send it to TowerTrigger to stop the shooting
        }
    }

}