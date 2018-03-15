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
    TowerFactory towerFactory;

    const int gridSize = 10;
    const string towerParentName = "Towers";

    void Start()
    {
        towerFactory = FindObjectOfType<TowerFactory>();
    }

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
                towerFactory.AddTower(transform.position);
                isPlaceable = false;
            }
            else
            {
                print("Can't place here");
            }
        }                
    }
}
