using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PathExplorer : MonoBehaviour {

    [SerializeField] Block startBlock, endBlock;

    //UnityEngine.Object[] blocks;
    //HashSet<Vector2Int> blockCoordinates = new HashSet<Vector2Int>();
    Dictionary<Vector2Int, Block> blocks = new Dictionary<Vector2Int, Block>();

    Vector2Int[] directions = {
        Vector2Int.up,
        Vector2Int.down,
        Vector2Int.left,
        Vector2Int.right
    };

	// Use this for initialization
	void Start ()
    {
        Debug.Assert(startBlock, "No start block found");
        Debug.Assert(endBlock, "No end block found");
        LoadBlocks();
        ExploreAllNodes();
    }

    private void LoadBlocks()
    {
        var blockObjects = FindObjectsOfType(typeof(Block));
        foreach (Block blockObject in blockObjects)
        {
            Vector2Int gridPos = blockObject.GetGridPos();
            bool positionOccupied = blocks.ContainsKey(gridPos);
            Debug.Assert(!positionOccupied, "Overlapping block " + blockObject);
            blocks.Add(gridPos, blockObject);
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
        if (blocks.ContainsKey(probeCoordinates))
        {
            print("Found block at " + probeCoordinates);
            blocks[probeCoordinates].SetExplored();
        }
        else
        {
            print("Nothing at " + probeCoordinates); 
        }
    }
}
