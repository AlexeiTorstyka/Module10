using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonGravityScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody == true)
        {
            other.attachedRigidbody.useGravity = false;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody == true)
        {
            other.attachedRigidbody.useGravity = true;
        }
    }
}
