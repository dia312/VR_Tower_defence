using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSys : MonoBehaviour {

    public static CoinSys instance;
    private int coin = 0;
    public Text CoinText;
    
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    public void AddCoin(int num)
    {
        coin += num;
        Debug.Log(num+","+coin);
        CoinText.text = "Coin : " + coin;
    }
    
    void Start()
    {

    }

    void Update()
    {

    }
}
