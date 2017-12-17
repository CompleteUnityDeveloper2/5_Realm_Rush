using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{    
    [SerializeField] [Range(0.1f, 100f)] float movementSpeed = 10f;

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
        path.Enqueue(new Node(10, 0));
        path.Enqueue(new Node(20, 0));
        path.Enqueue(new Node(30, 0));
        path.Enqueue(new Node(40, 0));
        path.Enqueue(new Node(40, 10));
        path.Enqueue(new Node(50, 20));
        path.Enqueue(new Node(60, 20));
        path.Enqueue(new Node(70, 20));
        path.Enqueue(new Node(80, 20));
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
