using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControls : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset = new Vector3(-30f, 15f, 0f);
    public float camSpeed = 3f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 newCamPos = new Vector3(offset.x, playerTransform.position.y + offset.y, playerTransform.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, newCamPos, camSpeed * Time.deltaTime);
    }
}
