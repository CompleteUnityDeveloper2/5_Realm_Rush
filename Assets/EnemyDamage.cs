using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    [SerializeField] Collider collisionMesh;

	// Use this for initialization
	void Start () {
		
	}
    private void OnParticleCollision(GameObject other)
    {
        print("I'm hit!");
    }
}
