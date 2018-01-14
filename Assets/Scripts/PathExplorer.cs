using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PathExplorer : MonoBehaviour {

    [SerializeField] Block startBlock, endBlock;

    UnityEngine.Object[] blocks;
    HashSet<Vector2Int> nodes = new HashSet<Vector2Int>();
    Vector2Int[] directions = {
        new Vector2Int( 0,  1), // up
        new Vector2Int( 1,  0), // right
        new Vector2Int( 0, -1), // down
        new Vector2Int(-1,  0), // down
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
            bool positionOccupied = nodes.Contains(gridPos);
            Debug.Assert(!positionOccupied, "Overlapping block " + block);
            nodes.Add(gridPos);
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
        if (nodes.Contains(probeCoordinates))
        {
            print("Found block at " + probeCoordinates);
        }
        else
        {
            print("Nothing at " + probeCoordinates); 
        }
    }
}
