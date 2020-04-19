using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Goblin_test2 : MonoBehaviour
{
    public Text coin;
    public GameObject myClone;
    public WaveSpawn2 waveSpawn2;
    UnityEngine.AI.NavMeshAgent agent;
    Transform castle;
    public int MAX_HP;
    public int dmg;
    public EnemyHp EHp;

    public GameObject Enemybug;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //Castle를 찾아서 그 위치를 세팅해준다
        castle = GameObject.Find("HM_Castle_1").transform;

        //에이전트 목적지를 타워로 세팅해준다.
        agent.destination = castle.position;


        EHp = Enemybug.GetComponent<EnemyHp>();

        Debug.Log("슈퍼적 HP" + EHp.hp);

        //내 클론을 설정한다
        myClone = waveSpawn2.clone;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ME"))
        {
            Castle.Instance.Damage(dmg);
        }
    }

    void Update()
    {
        if (EHp.hp <= 0)
        {
            if (myClone.tag != "Dead" )
                coin.text = (int.Parse(coin.text) + 10).ToString();
            myClone.tag = "Dead";
            Destroy(myClone);
            Debug.Log("Dead");
        }
    }
}