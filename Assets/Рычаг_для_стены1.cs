using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �����_���_�����1 : MonoBehaviour
{
    public GameObject �����2;
    public GameObject �����3;
    public GameObject lever;

    public static bool state = true;
    
    
    private void OnMouseDown()
    {
        state = !state;

        if (state)
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 315f);
            �����_���_�����.flag2 = !�����_���_�����.flag2;
            �����_���_�����.flag3 = !�����_���_�����.flag3;
        }

        else
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 45f);
            �����_���_�����.flag2 = !�����_���_�����.flag2;
            �����_���_�����.flag3 = !�����_���_�����.flag3;
        }

        if (�����_���_�����.flag2)
            �����2.transform.position += new Vector3(0, 20f, 0);
        else
            �����2.transform.position += new Vector3(0, -20f, 0);
        if (�����_���_�����.flag3)
            �����3.transform.position += new Vector3(0, 20f, 0);
        else
            �����3.transform.position += new Vector3(0, -20f, 0);
    }
}

