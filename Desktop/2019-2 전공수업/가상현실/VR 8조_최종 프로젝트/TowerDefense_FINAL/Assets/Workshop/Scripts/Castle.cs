using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour {

	public static Castle Instance;

    //HP를 표시할 슬라이더
    public Slider hpSlider;

	public int MAX_HP;
	int hp = 0;

    //시작할 땐 게임 오버가 아님
    bool gameOver = false;

	public GameObject die;

	void Awake()
	{
        
		if(Instance == null)
			Instance = this;
	}

	void Start()
	{
		hp = MAX_HP;
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
     
    }

	public void Damage(int DMG)
	{
		hp = hp-DMG;

        Debug.Log("데미지 ㅋ");
        //슬라이더에 HP를 세팅한다
        hpSlider.value = hp;
                
		if(hp <= 0)
		{
            //게임 오버 플래그를 켜준다
            gameOver = true;
            if (die)
			{
                Time.timeScale = 0.0f;
                die.SetActive(true);
            }
		}
	}
}
