using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] float secondsBetweenSpawns = 2f;
    [SerializeField] EnemyMovement enemyPrefab;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(RepeatedlySpawnEnemies());
	}
	
    IEnumerator RepeatedlySpawnEnemies()
    {
        while (true) // forever
        {
            print("Spawning"); 
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }
}
