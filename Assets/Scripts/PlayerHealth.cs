using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] int health = 10;
    [SerializeField] int healthDecrease = 1;

    private void OnTriggerEnter(Collider other)
    {
        health = health - healthDecrease;
    }

}
