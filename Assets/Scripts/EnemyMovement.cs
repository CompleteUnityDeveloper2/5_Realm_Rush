using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{    
    [SerializeField] [Range(0.1f, 100f)] float movementSpeed = 10f;
    [SerializeField] PathExplorer pathEplorer;

    List<Block> path;

    // Use this for initialization
    IEnumerator Start()
    {
        yield return StartCoroutine(pathEplorer.FindPath());
        path = pathEplorer.GetPath();
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        for (int blockIndex = 0; blockIndex < path.Count; blockIndex++)
        {
            Block destinationNode = path[blockIndex];
            yield return StartCoroutine(MoveToBlock(destinationNode));
        }
    }

    IEnumerator MoveToBlock(Block block)
    {
        float distanceRemaining;
        float distancePerFrame = movementSpeed * Time.deltaTime;
        do
        {
            distanceRemaining = (block.transform.position - transform.position).magnitude; 
            Vector3 direction = (block.transform.position - transform.position).normalized;
            transform.Translate(direction * distancePerFrame);
            yield return null; // wait a frame
        }
        while (distanceRemaining > distancePerFrame);
        yield return null;
    }
}
