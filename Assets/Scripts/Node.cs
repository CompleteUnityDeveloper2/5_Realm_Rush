using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// todo do we even need this concept?
public struct Node
{
    int xGridPos;
    int zGridPos;

    public int XGridPos { get { return xGridPos; } }
    public int ZGridPos { get { return zGridPos; } }
    public Vector3Int Position
    { 
        get
        {
            return new Vector3Int(xGridPos, 0, zGridPos);
        }
    }

    public Node(int x, int z)
    {
        xGridPos = x;
        zGridPos = z;
    }

    public override string ToString()
    {
        return XGridPos/10 + ", " + ZGridPos/10;
    }

}
