using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private Rigidbody Plate;
    [SerializeField] private float Force;
    public void AddForcedown()
    {
        Plate.AddForce(Vector3.down * Force * 50, ForceMode.Force);
    }
    public void AddForceLeft()
    {
        Plate.AddForce(Vector3.left * Force * 50, ForceMode.Force);
    }
}
