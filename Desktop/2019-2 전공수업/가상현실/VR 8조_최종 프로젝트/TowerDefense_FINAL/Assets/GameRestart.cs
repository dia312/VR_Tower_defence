using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour {
    Button RE;

    // Use this for initialization
    void Start()
    {
        RE = this.transform.GetComponent<Button>();
        RE.onClick.AddListener(REClick);
    }

    // Update is called once per frame
    public void REClick()
    {
        SceneManager.LoadScene("MainGame");
    }
}
