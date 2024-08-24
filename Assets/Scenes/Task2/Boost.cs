using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField] private float rad;
    public void boost()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, rad);
        foreach (Collider coll in colls)
        {
            coll.attachedRigidbody.AddForce(Vector3.up*100, ForceMode.Impulse);
        }
    }
    void Update()
    {
        boost();
    }
}
