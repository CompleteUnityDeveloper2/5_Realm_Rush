using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour {

    [Range(0.1f, 120f)]
    [SerializeField] float secondsBetweenSpawns = 2f;
    [SerializeField] EnemyMovement enemyPrefab;
    [SerializeField] Transform enemyParentTransform;
    [SerializeField] Text spawnedEnemies;
    int score;

	// Use this for initialization
	void Start ()
    {
        spawnedEnemies.text = score.ToString();
        StartCoroutine(RepeatedlySpawnEnemies());
	}
	
    IEnumerator RepeatedlySpawnEnemies()
    {
        while (true) // forever
        {
            var newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            newEnemy.transform.parent = enemyParentTransform;
            AddScore();
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

    void AddScore()
    {
        score++;
        spawnedEnemies.text = score.ToString();
    }
}
