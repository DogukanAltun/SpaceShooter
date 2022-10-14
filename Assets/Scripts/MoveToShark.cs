using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToShark : MonoBehaviour
{
    Rigidbody physic;
    [SerializeField] int horizontalspeed;
    [SerializeField] int verticalspeed;
    GameObject Player;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        physic = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Player != null)
        {
            if (Player.transform.position.x > transform.position.x)
            {
                physic.velocity = new Vector3(horizontalspeed, 0, -verticalspeed);
            }
            else if (Player.transform.position.x < transform.position.x)
            {
                physic.velocity = new Vector3(-horizontalspeed, 0, -verticalspeed);
            }
        }
    }
}
