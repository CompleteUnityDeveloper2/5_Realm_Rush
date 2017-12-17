using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] List<Node> path;
        
    // Use this for initialization
    void Start()
    {
        SetupPath();
        StartCoroutine(FollowPath());
    }

    private void SetupPath()
    {
        path = new List<Node>();
        path.Add(new Node(2, 0));
        path.Add(new Node(3, 0));
        path.Add(new Node(4, 0));
        path.Add(new Node(4, 1));
        print("Path setup"); 
    }


    IEnumerator FollowPath()
    {
        print("Setting off"); 
        foreach (Node node in path)
        {
            yield return StartCoroutine(MoveToNode(node));
        }
        print("Done");

    }

    IEnumerator MoveToNode(Node node)
    {
        print("Moving to " + node.ToString());
        yield return new WaitForSeconds(1f);
    }
}
