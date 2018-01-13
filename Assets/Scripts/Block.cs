using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Block : MonoBehaviour {

    [SerializeField] bool isPath = true;

    int gridScale = 10;
    public Vector3Int gridPos; // todo make private

	// Update is called once per frame
	void Update ()
    {
        if (Application.isEditor)
        {
            LabelBlocks();
            SnapBlocks(); // note better if order independent
        }
        else
        {
            // do nothing for now
        }
    }

    private void LabelBlocks()
    {
        TextMesh debugText = GetComponentInChildren<TextMesh>();
        debugText.text = gridPos.x / gridScale + ", " + gridPos.z / gridScale;
    }

    private void SnapBlocks()
    {
        gridPos.x = Mathf.RoundToInt(transform.position.x / gridScale) * gridScale;
        gridPos.z = Mathf.RoundToInt(transform.position.z / gridScale) * gridScale;
        transform.position = gridPos;
    }
}
