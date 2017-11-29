using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PathFollow : MonoBehaviour {

    Tilemap tileMap;


	// Use this for initialization
	void Start () {
        tileMap = FindObjectOfType<Tilemap>();
	}   
	
	// Update is called once per frame
	void Update () {
        Vector3 cell = tileMap.WorldToCell(transform.position);
        print(cell);
	}
}
