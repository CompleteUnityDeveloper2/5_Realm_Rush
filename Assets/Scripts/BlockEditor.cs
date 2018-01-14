using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof(Block))]
public class BlockEditor : MonoBehaviour {

    int gridScale = 10;
    Block block;
    Vector2Int gridPos;

    void Start()
    {
        block = GetComponent<Block>();
        gridPos.x = Mathf.RoundToInt(transform.position.x / 10);
        gridPos.y = Mathf.RoundToInt(transform.position.z / 10); 
    }

	// Update is called once per frame
	void Update ()
    {
        LabelBlocks(Application.isPlaying);
        SnapBlocks(); // note better if order independent
     }

    private void LabelBlocks(bool hideLabel)
    {
        TextMesh debugText = GetComponentInChildren<TextMesh>();
        if (hideLabel)
        {
            debugText.text = "";
        }
        else
        {
            debugText.text = gridPos.x + ", " + gridPos.y; // note is z
        }
    }

    private void SnapBlocks()
    {

        gridPos.x = Mathf.RoundToInt(transform.position.x / gridScale);
        gridPos.y = Mathf.RoundToInt(transform.position.z / gridScale);
        transform.position = new Vector3(gridPos.x, 0, gridPos.y) * gridScale;
    }
}
