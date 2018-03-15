using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    [SerializeField] Collider collisionMesh;
    [SerializeField] int hitPoints = 10;
    [SerializeField] ParticleSystem hitParticlePrefab;
    [SerializeField] ParticleSystem deathParticlePrefab;

	// Use this for initialization
	void Start () {
		
	}
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hitPoints <= 0)
        {
            KillEnemy();
        }
    }
    
    void ProcessHit()
    {
        hitPoints = hitPoints - 1;
        hitParticlePrefab.Play();
    }

    private void KillEnemy()
    {
        // important to instantiate before destroying this object
        var vfx = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
        vfx.Play();
        Destroy(gameObject);
    }
}
