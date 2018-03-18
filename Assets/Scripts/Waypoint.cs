using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    // public ok here as is a data class
    public bool isExplored = false;
    public Waypoint exploredFrom;
    public bool isPlaceable = true;

    Vector2Int gridPos;

    const int gridSize = 10;
    const string towerParentName = "Towers";

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize),
            Mathf.RoundToInt(transform.position.z / gridSize)
        );
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) // left click
        {
            if (isPlaceable)
            {
                FindObjectOfType<TowerFactory>().AddTower(this);
            }
            else
            {
                print("Can't place here");
            }
        }                
    }
}
