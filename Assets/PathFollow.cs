using System;
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
	void Update ()
    {
        print("Is plane over path? " + IsPathTile(transform.position));
        KeyboardMove();
    }

    private void KeyboardMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AttemptMove(new Vector3(0, 1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            AttemptMove(new Vector3(-1, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            AttemptMove(new Vector3(0, -1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            AttemptMove(new Vector3(1, 0, 0));
        }
    }

    private void AttemptMove(Vector3 movement)
    {
        Vector3 newPosition = transform.position + movement;
        if (IsPathTile(newPosition))
        {
            transform.position = newPosition;
        }
    }

    private bool IsPathTile(Vector3 worldPos)
    {
        Vector3Int cell = tilemap.WorldToCell(worldPos);
        string tileName = tilemap.GetTile(cell).name;
        return tileName.Substring(0, 5) == "path_";
    }
}
