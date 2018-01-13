using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof(Block))]
public class BlockEditor : MonoBehaviour {

    int gridScale = 10;
    Block block;

    void Start()
    {
        block = GetComponent<Block>();
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
            debugText.text = block.gridPos.x + ", " + block.gridPos.y; // note is z
        }
    }

    private void SnapBlocks()
    {
        block.gridPos.x = Mathf.RoundToInt(transform.position.x / gridScale);
        block.gridPos.y = Mathf.RoundToInt(transform.position.z / gridScale);
        transform.position = new Vector3(block.gridPos.x, 0, block.gridPos.y) * gridScale;
    }
}
