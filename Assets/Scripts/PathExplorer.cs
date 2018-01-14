using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PathExplorer : MonoBehaviour {

    [SerializeField] Block startBlock, endBlock;

    UnityEngine.Object[] blocks;
    HashSet<Vector2Int> testedBlocks = new HashSet<Vector2Int>();

	// Use this for initialization
	void Start ()
    {
        blocks = FindObjectsOfType(typeof(Block));
        CheckForValidMap();
    }

    private void CheckForValidMap()
    {
        CheckForOverlappingBlocks();
        Debug.Assert(startBlock, "No start block found");
        Debug.Assert(endBlock, "No end block found");
    }

    private void CheckForOverlappingBlocks()
    {
        Block firstOverlappingBlock = BlocksOverlap();
        if (firstOverlappingBlock)
        {
            Debug.LogError(
                firstOverlappingBlock.name + " at " +
                firstOverlappingBlock.GetGridPos() + " is overlapping, please remove"
            );
        }
        else
        {
            Debug.Log("No overlapping blocks, good job!");
        }
    }

    private Block BlocksOverlap()
    {
        foreach (Block block in blocks)
        {
            Vector2Int gridPos = block.GetGridPos();
            bool positionOccupied = testedBlocks.Contains(gridPos);
            if (positionOccupied) { return block; }
            testedBlocks.Add(gridPos);
        }
        return null;
    }
   

}
