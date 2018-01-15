using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PathExplorer : MonoBehaviour
{

    [SerializeField] [Range(0f, 2f)] float iterationDelay = 0.1f;
    [SerializeField] int iteration = 0;
    [SerializeField] Block startBlock, endBlock;

    enum State { NotRun, Running, FinishedSuccess, Failed }; // todo detect success vs failure
    [SerializeField] State state = State.NotRun;

    Dictionary<Vector2Int, Block> blocks = new Dictionary<Vector2Int, Block>();
    Queue<Block> queue = new Queue<Block>();
    List<Block> path = new List<Block>();

    Vector2Int[] directions = {
        Vector2Int.up,
        Vector2Int.right,
        Vector2Int.down,
        Vector2Int.left
    };

    // Use this for initialization
    IEnumerator Start()
    {
        Debug.Assert(startBlock, "No start block found");
        Debug.Assert(endBlock, "No end block found");
        LoadBlocks();
        yield return StartCoroutine(ExploreAllNodes());
        if (state == State.FinishedSuccess)
        {
            CreatePath();
        }
        SetBlockPathFlags();
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
   
    private IEnumerator ExploreAllNodes()
    {
        queue.Enqueue(startBlock);
        state = State.Running;

        while (queue.Count > 0)
        {
            var blockToSearchFrom = queue.Dequeue();

            if (blockToSearchFrom == endBlock)
            {
                state = State.FinishedSuccess;
                endBlock.SetExplored();
                break;
            }

            SearchFromPosition(blockToSearchFrom);
            yield return new WaitForSeconds(iterationDelay);
        }
        if (state != State.FinishedSuccess) { state = State.Failed; }
        yield return new WaitForEndOfFrame();
    }

    private void CreatePath()
    {
        path.Add(endBlock);

        Block previousBlock = endBlock.GetExploredFrom();
        while (previousBlock != startBlock)
        {
            path.Add(previousBlock);
            previousBlock = previousBlock.GetExploredFrom();
        }

        path.Add(startBlock); 

        path.Reverse();
    }

    private void SetBlockPathFlags()
    {
        foreach (Block block in path)
        {
            block.SetOnPath();
        }
    }

    private void SearchFromPosition(Block searchBlock)
    {
        Vector2Int searchCenter = searchBlock.GetGridPos();
        foreach (Vector2Int direction in directions)
        {
            Vector2Int searchPosition = searchCenter + direction;
            if (IsNeighbourUnexplored(searchPosition))
            {
                Block blockToQueue = blocks[searchPosition];
                if (!queue.Contains(blockToQueue)) // prevenet duplicates
                {
                    queue.Enqueue(blockToQueue);
                }
                searchBlock.SetExplored();
                blockToQueue.SetExploredFrom(searchBlock);
            }
        }
    }

    private bool IsNeighbourUnexplored(Vector2Int searchPosition)
    {
        Block targetBlock;
        try
        {
            targetBlock = blocks[searchPosition];
        }
        catch
        {
            return false;
        }
        finally
        {
            iteration++;
        }

        bool isBlockAtTarget = blocks.ContainsKey(searchPosition);
        bool targetIsExplored = targetBlock.IsExplored();
        bool targetIsBlocked = targetBlock.IsBlocked();

        if (isBlockAtTarget && !targetIsExplored && !targetIsBlocked)
        {
            return true;
        }
        return false;
    }
}
