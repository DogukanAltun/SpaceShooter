using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float lifeTime;
    public void Start()
    {
     Destroy(gameObject, lifeTime);
    }
  
}
