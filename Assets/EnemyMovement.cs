using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{    
    [SerializeField] float movementSpeed = 1f;

    Queue<Node> path;
    Node startNode, previousNode;

    // Use this for initialization
    void Start()
    {
        SetupPath();
        MoveToStart();
        StartCoroutine(FollowPath());
    }

    void SetupPath()
    {
        path = new Queue<Node>();
        path.Enqueue(new Node(2, 0));
        path.Enqueue(new Node(3, 0));
        path.Enqueue(new Node(4, 0));
        path.Enqueue(new Node(4, 1));
        path.Enqueue(new Node(5, 2));
        path.Enqueue(new Node(6, 2));
        path.Enqueue(new Node(7, 2));
        print("Path setup");
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
            yield return StartCoroutine(MoveToNode(destinationNode));
            yield return new WaitForSeconds(1f);
            previousNode = destinationNode;
        }
        print("Done");
    }

    IEnumerator MoveToNode(Node node)
    {
        print("Moving to " + node.ToString()); 
        Vector3 translation;
        do
        {
            translation = node.Position - transform.position;
            transform.Translate(translation.normalized * Time.deltaTime);
            print(translation.magnitude);
            yield return null; // wait a frame
        }
        while (translation.magnitude > 0.1f);
        yield return null;
    }
}
