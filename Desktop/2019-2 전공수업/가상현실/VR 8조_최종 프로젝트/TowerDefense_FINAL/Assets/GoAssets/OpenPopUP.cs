using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPopUP : MonoBehaviour
{
    public Text popUpCoinText;
    public Text allCoinText;
    Button open;
    // Use this for initialization
    void Start()
    {
        open = this.transform.GetComponent<Button>();
        open.onClick.AddListener(openClick);
    }


    // Update is called once per frame
    public void openClick()
    {
        transform.Find("PopUp").gameObject.SetActive(true);
        popUpCoinText.text = allCoinText.text;
    }
}
