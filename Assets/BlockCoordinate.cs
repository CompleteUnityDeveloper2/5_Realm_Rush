using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCoordinate : MonoBehaviour {

    int xGridPos, zGridPos;

    // Use this for initialization
    void Start () {
        xGridPos = Mathf.RoundToInt(transform.position.x);
        zGridPos = Mathf.RoundToInt(transform.position.z);

        TextMesh debugText = GetComponent<TextMesh>();
        debugText.text = xGridPos + "," + zGridPos;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
