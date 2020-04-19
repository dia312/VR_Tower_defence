using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Goblin_test : MonoBehaviour
{
    public Slider castleSlider;
    public Text coin;
    public GameObject myClone;
    public WaveSpawn1 waveSpawn1;
    UnityEngine.AI.NavMeshAgent agent;
    Transform castle;
    public GameObject Enemybug;
    public EnemyHp EHp;
    public int dmg=10;

    //public GameObject Enemybug;


    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //Castle를 찾아서 그 위치를 세팅해준다
        castle = GameObject.Find("HM_Castle_1").transform;

        //에이전트 목적지를 타워로 세팅해준다.
        agent.destination = castle.position;

        EHp = Enemybug.GetComponent<EnemyHp>();

        Debug.Log("적 HP" + EHp.hp);

        //내 클론을 설정한다
        myClone = waveSpawn1.clone;

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
            if (myClone.tag != "Dead")
                coin.text = (int.Parse(coin.text) + 10).ToString();
            myClone.tag = "Dead";
            Destroy(myClone);
            Debug.Log("Dead");
        }
    }
}