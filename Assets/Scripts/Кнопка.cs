using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Кнопка : MonoBehaviour
{
    public GameObject button;
    public float timer = 1;
    private float timeDown = 1;
    public static int flag = 0;
    public static bool b_active = false;
    public LayerMask playerLayer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && b_active == false && Physics.CheckSphere(button.transform.position, 2f, playerLayer))
        {
            gameObject.transform.position -= new Vector3(0, 0.2f, 0);
            timeDown = timer;
            b_active = true;
            flag = 1;
        }
        if (b_active)
        {
            if (timeDown > 0)
                timeDown -= Time.deltaTime;
            if (timeDown < 0)
                timeDown = 0;
            if (timeDown == 0)
            {
                gameObject.transform.position += new Vector3(0, 0.2f, 0);
                b_active = false;
            }
        }
    }
}
