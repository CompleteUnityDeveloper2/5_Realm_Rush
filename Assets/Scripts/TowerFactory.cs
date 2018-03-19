using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour {

    [SerializeField] Tower towerPrefab;
    [SerializeField] int towerLimit = 5;

    Queue<Tower> towerQueue = new Queue<Tower>();

    public void AddTower(Waypoint baseWaypoint)
    {
        if (towerQueue.Count < towerLimit)
        {
            InstantiateNewTower(baseWaypoint);
        }
        else
        {
            MoveExistingTower(baseWaypoint);
        }
    }

    private void InstantiateNewTower(Waypoint baseWaypoint)
    {
        Vector3 newPos = baseWaypoint.transform.position;
        var newTower = Instantiate(towerPrefab, newPos, Quaternion.identity);

        newTower.baseWaypoint = baseWaypoint;
        baseWaypoint.isPlaceable = false;

        towerQueue.Enqueue(newTower);
    }

    private void MoveExistingTower(Waypoint baseWaypoint)
    {
        var oldTower = towerQueue.Dequeue();

        oldTower.baseWaypoint.isPlaceable = true;
        baseWaypoint.isPlaceable = false;

        oldTower.baseWaypoint = baseWaypoint;
        oldTower.transform.position = baseWaypoint.transform.position;

        towerQueue.Enqueue(oldTower); // stick it back on top of the pile
    }
}
