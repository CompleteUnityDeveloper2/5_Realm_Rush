using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour {

    [SerializeField] Tower towerPrefab;
    [SerializeField] int towerLimit = 5;

    Queue<Tower> towerQueue = new Queue<Tower>();

    public void AddTower(Waypoint baseWaypoint)
    {
        Vector3 newPos = baseWaypoint.transform.position;
        if (towerQueue.Count < towerLimit)
        {
            InstantiateNewTower(baseWaypoint, newPos);
        }
        else
        {
            MoveExistingTower(baseWaypoint, newPos);
        }
    }

    private void InstantiateNewTower(Waypoint baseWaypoint, Vector3 newPos)
    {
        var newTower = Instantiate(towerPrefab, newPos, Quaternion.identity);

        newTower.baseWaypoint = baseWaypoint;
        baseWaypoint.isPlaceable = false;

        towerQueue.Enqueue(newTower);
    }

    private void MoveExistingTower(Waypoint newBaseWaypoint, Vector3 newPos)
    {
        var oldTower = towerQueue.Dequeue();

        oldTower.baseWaypoint.isPlaceable = true;
        newBaseWaypoint.isPlaceable = false;

        oldTower.baseWaypoint = newBaseWaypoint;
        oldTower.transform.position = newPos;

        towerQueue.Enqueue(oldTower); // stick it back on top of the pile
    }
}
