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
            InstantiateNewTower(waypoint, newPos);
            return true;
        }
        MoveExistingTower(waypoint, newPos);
        return false;
    }

    private void InstantiateNewTower(Waypoint waypoint, Vector3 newPos)
    {
        var newTower = Instantiate(towerPrefab, newPos, Quaternion.identity);

        newTower.waypoint = waypoint;
        waypoint.isPlaceable = false;

        towerQueue.Enqueue(newTower);
    }

    private void MoveExistingTower(Waypoint newWayPoint, Vector3 newPos)
    {
        var oldTower = towerQueue.Dequeue();

        oldTower.waypoint.isPlaceable = true;
        newWayPoint.isPlaceable = false;

        oldTower.waypoint = newWayPoint;
        oldTower.transform.position = newPos;

        towerQueue.Enqueue(oldTower); // stick it back on top of the pile
    }
}
