using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class straight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.Rotate(0, 180, 0);
	}
}
