using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlockCoordinate : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        Node node = new Node(
            Mathf.RoundToInt(transform.position.x),
            Mathf.RoundToInt(transform.position.z)
        );

        TextMesh debugText = GetComponent<TextMesh>();
        debugText.text = node.ToString();
    }
}
