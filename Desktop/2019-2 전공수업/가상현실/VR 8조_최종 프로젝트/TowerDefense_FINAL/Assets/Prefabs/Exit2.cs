using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit2 : MonoBehaviour {

    Button exit2;
    // Use this for initialization
    void Start()
    {
        exit2 = this.transform.GetComponent<Button>();
        exit2.onClick.AddListener(exit2Click);
    }

    // Update is called once per frame
    public void exit2Click()
    {
        GameObject.Find("PopUp").transform.Find("cantbuy").gameObject.SetActive(false);
    }
}
