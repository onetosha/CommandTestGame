using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Телега : MonoBehaviour
{
    private Rigidbody car;
    public static float speedMultiplier = 0f;
    
    private void Start()
    {
        car = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        car.AddRelativeForce(Vector3.forward * speedMultiplier);
    }
}
