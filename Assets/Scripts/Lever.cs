using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject lever;
    public LayerMask playerLayer;

    public static int state = 0;
    int temp = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Physics.CheckSphere(lever.transform.position, 1f, playerLayer))
        {
            if (state == 0 && temp == 1)
            {
                state = -1;
                temp = 0;
            }
            else if (state == -1)
            {
                state = 0;
                temp = -1;
            }
            else if (state == 0 && temp == -1)
            {
                state = 1;
                temp = 0;
            }
            else
            {
                state = 0;
                temp = 1;
            }
        }

        if (state == 1)
        {
            lever.transform.eulerAngles = new Vector3(45, 0, 0);
            ??????.speedMultiplier = 20f;
        }
        else if (state == 0)
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 0);
            ??????.speedMultiplier = 0f;
        }
        else
        {
            lever.transform.eulerAngles = new Vector3(-45, 0, 0);
            ??????.speedMultiplier = -20f;
        }
    }
}
