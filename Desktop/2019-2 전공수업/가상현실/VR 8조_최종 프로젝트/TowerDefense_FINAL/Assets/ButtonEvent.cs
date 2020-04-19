using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Text coinvalue;
    public GameObject panel;
    public static Button hpPlus;
    public Slider towerHp;
    // Use this for initialization
    void Start()
    {
        Debug.Log("------------------------출력---------------=");
        Debug.Log("Button Start");
        //hpPlus = this.GetComponent<Button>();
        //hpPlus.onClick.AddListener(openClick);

        Debug.Log("------------------------출력---------------=");
        Debug.Log("towerHp등록 ");
    }


    // Update is called once per frame
    public void openClick()
    {
        if (int.Parse(coinvalue.text) >= 50)
        {
            towerHp.value += 30;
            coinvalue.text = (int.Parse(coinvalue.text) - 50).ToString();
        }
        else if (int.Parse(coinvalue.text) < 50)
        {
            GameObject.Find("PopUp").transform.Find("cantbuy").gameObject.SetActive(true);
        }
    }
}
