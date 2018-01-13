using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PathExplorer : MonoBehaviour {

    UnityEngine.Object[] blocks;
    HashSet<Vector2Int> testedBlocks = new HashSet<Vector2Int>();

	// Use this for initialization
	void Start ()
    {
        Block firstOverlappingBlock = BlocksOverlap();
        if (firstOverlappingBlock)
        {
            Debug.LogError(
                firstOverlappingBlock.name + " at " +
                firstOverlappingBlock.gridPos + " is overlapping, please remove"
            );
        }
        else
        {
            Debug.Log("No overlapping blocks, good job!");
        }
	}

    private Block BlocksOverlap()
    {
        blocks = FindObjectsOfType(typeof(Block));
        foreach (Block block in blocks)
        {
            bool positionOccupied = testedBlocks.Contains(block.gridPos);
            if (positionOccupied) { return block; }
            testedBlocks.Add(block.gridPos);
        }
        return null;
    }
}
