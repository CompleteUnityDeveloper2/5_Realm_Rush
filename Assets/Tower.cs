using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    [SerializeField] Transform objectToPan;
    [SerializeField] Enemy targetEnemy;

    // Update is called once per frame
    void Update()
    {
        float aimHeight = targetEnemy.GetHeadHeight();
        Vector3 aimOffset = new Vector3(0f, aimHeight, 0f);
        objectToPan.LookAt(targetEnemy.transform.position + aimOffset);
    }
}
