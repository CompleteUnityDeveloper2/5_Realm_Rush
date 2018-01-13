using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PathExplorer : MonoBehaviour {

    Object[] blocks;

	// Use this for initialization
	void Start () {
        blocks = FindObjectsOfType(typeof(Block));
        foreach (Block block in blocks)
        {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
