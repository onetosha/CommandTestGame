using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MouseMove : MonoBehaviour
{
    float xRot;
    float yRot;
    float xRotCurrent;
    float yRotCurrent;
    public Camera player;
    public GameObject playerGameObject;
    public float sensivity = 5f;
    float smoothTime = 0.1f;
    float currentVelosityX;
    float currentVelosityY;
    void Update()
    {
        MouseMove();
    }
    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X") * sensivity;
        yRot += Input.GetAxis("Mouse Y") * sensivity;
        xRotCurrent = Mathf.SmoothDamp(xRot, xRotCurrent, ref currentVelosityX, smoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRot, yRotCurrent, ref currentVelosityY, smoothTime);
        player.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRot, 0f);
    }
}
