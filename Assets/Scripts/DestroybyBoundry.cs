using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyBoundry : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
