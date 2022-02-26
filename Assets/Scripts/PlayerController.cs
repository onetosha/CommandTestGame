using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 5.7f;
    public float rotationSpeed = 5.7f;
    public float jumpForce = 5f;
    public Transform gcTransform;
    public LayerMask gLayer;
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
        Vector3 moveDir = Vector3.ClampMagnitude(directionVector, 1) * speed;
        _rigidbody.velocity = new Vector3(moveDir.x, _rigidbody.velocity.y, moveDir.z);
        _rigidbody.angularVelocity = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Physics.CheckSphere(gcTransform.position, 0.2f, gLayer))
        {
            _animator.SetBool("inAir", false);
        }
        else
        {
            _animator.SetBool("inAir", true);
        }
    }

    void Jump()
    {
        if (Physics.CheckSphere(gcTransform.position, 0.4f, gLayer))
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
