using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Force : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private Rigidbody obj;
    public void Click()
    {
        obj.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
