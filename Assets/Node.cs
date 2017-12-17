using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    int xGridPos;
    int zGridPos;

    public int XGridPos { get { return xGridPos; } }
    public int ZGridPos { get { return zGridPos; } }

    public Node(int x, int z)
    {
        xGridPos = x;
        zGridPos = z;
    }
}
