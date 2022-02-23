using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 20f;
    public float rotationSpeed = 20f;
    private Animator _animator;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 directionVector = new Vector3(vertical, 0, -horizontal);
        if (directionVector.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);

        _animator.SetFloat("changingSpeed", Vector3.ClampMagnitude(directionVector, 1).magnitude);

        _rigidbody.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
    }
}
