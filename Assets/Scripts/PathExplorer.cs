using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PathExplorer : MonoBehaviour {

    [SerializeField] Block startBlock, endBlock;

    UnityEngine.Object[] blocks;
    HashSet<Vector2Int> blockCoordinates = new HashSet<Vector2Int>();
    Dictionary<Vector2Int, Block> blocksDictTemp;

    Vector2Int[] directions = {
        Vector2Int.up,
        Vector2Int.down,
        Vector2Int.left,
        Vector2Int.right
    };

	// Use this for initialization
	void Start ()
    {
        blocks = FindObjectsOfType(typeof(Block));
        Debug.Assert(startBlock, "No start block found");
        Debug.Assert(endBlock, "No end block found");
        LoadBlocksAsNodes();
        ExploreAllNodes();
    }

    private void LoadBlocksAsNodes()
    {
        foreach (Block block in blocks)
        {
            Vector2Int gridPos = block.GetGridPos();
            bool positionOccupied = blockCoordinates.Contains(gridPos);
            Debug.Assert(!positionOccupied, "Overlapping block " + block);
            blockCoordinates.Add(gridPos);
        }
    }
   
    private void ExploreAllNodes()
    {
        Vector2Int currentNode = startBlock.GetGridPos();
        print("Starting with node:" + currentNode);
        foreach (Vector2Int direction in directions)
        {
            Vector2Int probeCoordinates = currentNode + direction;
            EnqueueNodeInDirection(probeCoordinates);
        }
    }

    private void EnqueueNodeInDirection(Vector2Int probeCoordinates)
    {
        if (blockCoordinates.Contains(probeCoordinates))
        {
            print("Found block at " + probeCoordinates);

        }
        else
        {
            print("Nothing at " + probeCoordinates); 
        }
    }
}
