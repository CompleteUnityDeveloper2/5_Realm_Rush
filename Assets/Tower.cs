using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    [SerializeField] Transform objectToPan;
    [SerializeField] EnemyMovement targetEnemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AimAtWorldCoordinates(targetEnemy.transform.forward);
	}

    void AimAtWorldCoordinates(Vector3 coordinates)
    {
        Vector3 targetDir = targetEnemy.transform.position - transform.position;
        print(Vector3.Angle(targetDir, transform.forward));
    }
}
