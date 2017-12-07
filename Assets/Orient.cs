using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orient : MonoBehaviour {

    [SerializeField] Text textBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
        {
            textBox.text = "Landscape Left";
        }
        else
        {
            textBox.text = "Something else";
        }
	}
}
