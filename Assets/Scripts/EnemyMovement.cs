using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{    
    [SerializeField] [Range(0.01f, 10f)] float movementSpeed = 1f;

    Queue<Node> path;
    Node startNode, previousNode;

    // Use this for initialization
    void Start()
    {
        SetupPath();
        MoveToStart();
        StartCoroutine(FollowPath());
    }

    // todo move data out
    void SetupPath()
    {
        path = new Queue<Node>();
        path.Enqueue(new Node(0, 0));
        path.Enqueue(new Node(1, 0));
        path.Enqueue(new Node(2, 0));
        path.Enqueue(new Node(3, 0));
        path.Enqueue(new Node(4, 0));
        path.Enqueue(new Node(4, 1));
        path.Enqueue(new Node(5, 2));
        path.Enqueue(new Node(6, 2));
        path.Enqueue(new Node(7, 2));
        path.Enqueue(new Node(8, 2));
    }

    void MoveToStart()
    {
        startNode = path.Dequeue();
        transform.position = startNode.Position;
        previousNode = startNode;
    }

    IEnumerator FollowPath()
    {
        while (path.Count > 0)
        {
            Node destinationNode = path.Dequeue();
            previousNode = destinationNode;
            yield return StartCoroutine(MoveToNode(destinationNode));
        }
    }

    IEnumerator MoveToNode(Node node)
    {
        float distanceRemaining;
        float distancePerFrame = movementSpeed * Time.deltaTime;
        do
        {
            distanceRemaining = (node.Position - transform.position).magnitude; 
            Vector3 direction = (node.Position - transform.position).normalized;
            transform.Translate(direction * distancePerFrame);
            yield return null; // wait a frame
        }
        while (distanceRemaining > distancePerFrame);
        yield return null;
    }
}
