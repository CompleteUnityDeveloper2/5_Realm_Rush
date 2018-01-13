using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Block : MonoBehaviour {

    [SerializeField] bool isPath = true;

    int gridScale = 10;
    Vector3Int gridPos = new Vector3Int(); // todo make pricate

	// Update is called once per frame
	void Update ()
    {
        SnapToGrid();
        LabelBlock();
    }

    private void LabelBlock()
    {
        TextMesh debugText = GetComponentInChildren<TextMesh>();
        debugText.text = gridPos.x / gridScale + ", " + gridPos.z / gridScale;
    }

    private void SnapToGrid()
    {
        gridPos.x = Mathf.RoundToInt(transform.position.x / gridScale) * gridScale;
        gridPos.z = Mathf.RoundToInt(transform.position.z / gridScale) * gridScale;
        transform.position = gridPos;
    }
}
