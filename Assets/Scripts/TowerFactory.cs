using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour {

    [SerializeField] Tower towerPrefab;
    [SerializeField] int towerLimit = 5;

    Queue<Tower> towerQueue = new Queue<Tower>();

    private void Update()
    {
        print(towerQueue.Count); 
    }

    public bool AddTower(Waypoint waypoint)
    {
        Vector3 newPos = waypoint.transform.position;
        if (towerQueue.Count < towerLimit)
        {
            var newTower = Instantiate(towerPrefab, newPos, Quaternion.identity);
            newTower.waypoint = waypoint;
            towerQueue.Enqueue(newTower);
            return true;
        }
        var oldTower = towerQueue.Dequeue();
        towerQueue.Enqueue(oldTower); // put it back on top
        oldTower.waypoint.isPlaceable = true;
        oldTower.waypoint = waypoint;
        oldTower.transform.position = newPos;
        return false;
    }
}
