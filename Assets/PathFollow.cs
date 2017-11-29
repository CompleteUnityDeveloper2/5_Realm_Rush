using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PathFollow : MonoBehaviour {

    Tilemap tilemap;


	// Use this for initialization
	void Start () {
        tilemap = FindObjectOfType<Tilemap>();
	}   
	
	// Update is called once per frame
	void Update () {
        Vector3Int cell = tilemap.WorldToCell(transform.position);
        print(tilemap.GetTile(cell).name);
	}
}
