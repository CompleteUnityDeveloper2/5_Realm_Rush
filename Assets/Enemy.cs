using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] List<Waypoint> path;

    [Tooltip("Used for where towers aim at")]
    [SerializeField] float headHeight;

	// Use this for initialization
	void Start () {
        StartCoroutine(FollowPath());
	}

    public float GetHeadHeight()
    {
        return headHeight;
    }

    IEnumerator FollowPath()
    {
        print("Starting patrol..."); 
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1f);
        }
        print("Ending patrol");
    }
}
