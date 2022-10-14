using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMeteor : MonoBehaviour
{
    Rigidbody physic;
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        physic.angularVelocity = Random.insideUnitSphere*3;
    }

    
}
