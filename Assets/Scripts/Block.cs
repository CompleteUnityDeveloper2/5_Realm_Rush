using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Block : MonoBehaviour {

    [SerializeField] bool isPath = true;

    Vector3 snapPos = new Vector3();

	// Update is called once per frame
	void Update ()
    {
        SnapToGrid();
        LabelBlock();
    }

    private void LabelBlock()
    {
        Node node = new Node((int)snapPos.x, (int)snapPos.z);
        TextMesh debugText = GetComponentInChildren<TextMesh>();
        debugText.text = node.ToString();
    }

    private void SnapToGrid()
    {
        snapPos.x = Mathf.Round(transform.position.x / 10f) * 10f;
        snapPos.z = Mathf.Round(transform.position.z / 10f) * 10f;
        transform.position = snapPos;
    }
}
