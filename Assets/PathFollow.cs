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
        InvokeRepeating("AutoMove", 0f, .5f);
	}   

	// Update is called once per frame
	void Update ()
    {
        KeyboardMove();
    }

    private void AutoMove()
    {
        Vector3[] moveList = {
            new Vector3(1f, 0, 0),
            new Vector3(0, 1f, 0)
        };

        if (IsValidMove(transform.position + moveList[0]))
        {
            Move(moveList[0]);
        }
        else if (IsValidMove(transform.position + moveList[1]))
        {
            Move(moveList[1]);
        }
    }

    private void KeyboardMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Move(new Vector3(0, 1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Move(new Vector3(-1, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Move(new Vector3(0, -1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Move(new Vector3(1, 0, 0));
        }
    }

    private bool IsValidMove(Vector3 newPosition)
    {
        if (IsPathTile(newPosition))
        {
            return true;
        }
        return false;
    }

    private void Move(Vector3 movement)
    {
        Vector3 newPosition = transform.position + movement;
        if (IsValidMove(newPosition))
        {
            transform.position = newPosition;
        }
    }

    private bool IsPathTile(Vector3 worldPos)
    {
        Vector3Int cell = tilemap.WorldToCell(worldPos);
        var tile = tilemap.GetTile(cell);
        if (tile)
        {
            string tileName = tile.name;
            return tileName.Substring(0, 5) == "path_";
        }
        else
        {
            return false;
        }
    }
}
