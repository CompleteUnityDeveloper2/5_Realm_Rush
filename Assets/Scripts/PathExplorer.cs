using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PathExplorer : MonoBehaviour {

    [SerializeField] Block startBlock, endBlock;

    Dictionary<Vector2Int, Block> blocks = new Dictionary<Vector2Int, Block>();
    Queue<Block> queue = new Queue<Block>();

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
        queue.Enqueue(startBlock);

        Block blockToSearchFrom;
        do
        {
            blockToSearchFrom = queue.Dequeue();
            SearchFromBlock(blockToSearchFrom);
        }
        while (blockToSearchFrom != endBlock);
    }

    private void SearchFromBlock(Block blockToSearchFrom)
    {
        foreach (Vector2Int direction in directions)
        {
            Vector2Int probeCoordinates = blockToSearchFrom.GetGridPos() + direction;
            EnqueueNodeInDirection(probeCoordinates);
        }
    }

    private void EnqueueNodeInDirection(Vector2Int probeCoordinates)
    {
        if (blocks.ContainsKey(probeCoordinates))
        {
            blocks[probeCoordinates].SetExplored();
            queue.Enqueue(blocks[probeCoordinates]);
        }
        else
        {
            // do nothing
        }
    }
}
