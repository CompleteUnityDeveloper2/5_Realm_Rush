using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PathExplorer : MonoBehaviour {

    UnityEngine.Object[] blocks;
    List<Vector2Int> testedBlocks = new List<Vector2Int>();

	// Use this for initialization
	void Start ()
    {
        if (Application.isPlaying)
        {
            print("Checking for overlaps...");
            print(CheckForOverlappingBlocks());
        }
	}

    private bool CheckForOverlappingBlocks()
    {
        blocks = FindObjectsOfType(typeof(Block));
        foreach (Block block in blocks)
        {
            if (testedBlocks.Contains(block.gridPos))
            {
                Debug.LogError(block.name + " at " + block.gridPos + " is overlapping, please remove");
                return true;
            }
            else
            {
                testedBlocks.Add(block.gridPos);
            }
        }
        return false;
    }
}
