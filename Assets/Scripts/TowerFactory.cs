using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour {

    [SerializeField] Tower towerPrefab;
    [SerializeField] int towerLimit = 5;

    int towers;

    public void AddTower(Vector3 position)
    {
        if (towers < towerLimit)
        {
            Instantiate(towerPrefab, position, Quaternion.identity);
            towers++;
        }
    }
}
