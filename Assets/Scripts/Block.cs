using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] bool isPath = true;
    public Vector2Int gridPos; // todo make private

	// Use this for initialization
	void Start () {
        gridPos.x = Mathf.RoundToInt(transform.position.x / 10);
        gridPos.y = Mathf.RoundToInt(transform.position.z / 10);
	}
	
    public void SetBlocked()
    {
        isPath = false;
    }
}
