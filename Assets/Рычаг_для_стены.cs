using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �����_���_����� : MonoBehaviour
{
    public GameObject �����1;
    public GameObject �����3;
    public GameObject lever;

    public static bool flag1 = false, flag2 = false, flag3 = false;

    public static bool state = true;
    
    
    private void OnMouseDown()
    {
        state = !state;

        if (state)
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 315f);
            flag1 = !flag1;
            flag3 = !flag3;
        }
        
        else
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 45f);
            flag1 = !flag1;
            flag3 = !flag3;
        }

        if (flag1)
            �����1.transform.position += new Vector3(0, 20f, 0);
        else
            �����1.transform.position += new Vector3(0, -20f, 0);
        if (flag3)
            �����3.transform.position += new Vector3(0, 20f, 0);
        else
            �����3.transform.position += new Vector3(0, -20f, 0);
    }
}
