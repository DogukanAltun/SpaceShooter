using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody physic;
    [SerializeField] int speed;
    void Start()
    {
        physic=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        physic.velocity = Vector3.forward * speed;
    }
}
