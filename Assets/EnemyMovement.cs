using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] Queue<Node> path;

    Node previousNode;

    // Use this for initialization
    void Start()
    {
        SetupPath();
        StartCoroutine(FollowPath());
    }

    private void SetupPath()
    {
        path = new Queue<Node>();
        path.Enqueue(new Node(2, 0));
        path.Enqueue(new Node(3, 0));
        path.Enqueue(new Node(4, 0));
        path.Enqueue(new Node(4, 1));
        print("Path setup"); 
    }


    IEnumerator FollowPath()
    {
        previousNode = path.Dequeue();

        while (path.Count > 0)
        {
            Node destinationNode = path.Dequeue();
            yield return StartCoroutine(MoveToNode(destinationNode));
            previousNode = destinationNode;
        }
        print("Done");

    }

    IEnumerator MoveToNode(Node node)
    {
        print("Moving from " + previousNode.ToString() + " to " + node.ToString());

        yield return new WaitForSeconds(1f);
    }
}
