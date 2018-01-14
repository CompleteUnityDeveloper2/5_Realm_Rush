using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[ExecuteInEditMode]
public class BlockLight : MonoBehaviour {

    [SerializeField] Color unExplored, explored;

    Block block;
    Light blockLight;

	// Use this for initialization
	void Start () {
        block = GetComponentInParent<Block>();
        if (block == null) {
            Debug.LogError("No block found for light " + gameObject.name);
            return;
        }
        blockLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (block.IsExplored())
        {
            blockLight.color = explored;
        }
        else
        {
            blockLight.color = unExplored;
        }
	}
}
