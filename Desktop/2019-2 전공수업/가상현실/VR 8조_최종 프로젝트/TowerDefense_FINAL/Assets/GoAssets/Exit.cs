using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Text popUpCoinText;
    public Text allCoinText;
    Button exit;
    // Use this for initialization
    void Start()
    {
        exit = this.transform.GetComponent<Button>();
        exit.onClick.AddListener(exitClick);
    }

    // Update is called once per frame
    public void exitClick()
    {
        GameObject.Find("Open").transform.Find("PopUp").gameObject.SetActive(false);
        allCoinText.text = popUpCoinText.text;
    }
}
