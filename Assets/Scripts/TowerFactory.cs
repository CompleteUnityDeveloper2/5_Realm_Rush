using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour {

    [SerializeField] Tower towerPrefab;
    [SerializeField] int towerLimit = 5;

    Queue<Tower> towerQueue = new Queue<Tower>();

    public bool AddTower(Waypoint waypoint)
    {
        Vector3 newPos = waypoint.transform.position;
        if (towerQueue.Count < towerLimit)
        {
            var newTower = Instantiate(towerPrefab, newPos, Quaternion.identity);
            towerQueue.Enqueue(newTower);
            return true;
        }
        else
        {
            var oldTower = towerQueue.Dequeue();
            oldTower.transform.position = newPos;
            return false;
        }
    }
}
