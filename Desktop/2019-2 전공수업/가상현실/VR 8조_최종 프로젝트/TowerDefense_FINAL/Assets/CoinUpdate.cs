using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUpdate : MonoBehaviour
{

    public Text newcoin;
    public Text oldcoin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        oldcoin.text = newcoin.text;
    }
}