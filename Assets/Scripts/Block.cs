using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Block : MonoBehaviour {

    // todo stop exposing these or make readonly
    [SerializeField] Vector2Int gridPos;
    [SerializeField] bool blocked = false;
    [SerializeField] bool explored = false;

	// Use this for initialization
	void Awake () { // Awake so initialised ready for path explorer
        gridPos.x = Mathf.RoundToInt(transform.position.x / 10);
        gridPos.y = Mathf.RoundToInt(transform.position.z / 10);
	}
	
    public void SetBlocked()
    {
        blocked = false;
    }

    public Vector2Int GetGridPos()
    {
        return gridPos;
    }

    public void SetExplored()
    {
        explored = true;
    }

    public bool IsExplored()
    {
        return explored;
    }

    public bool IsBlocked()
    {
        return blocked;
    }
}
