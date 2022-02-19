using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Рычаг_для_стены1 : MonoBehaviour
{
    public GameObject Стена2;
    public GameObject Стена3;
    public GameObject lever;

    public static bool state = true;
    
    
    private void OnMouseDown()
    {
        state = !state;

        if (state)
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 315f);
            Рычаг_для_стены.flag2 = !Рычаг_для_стены.flag2;
            Рычаг_для_стены.flag3 = !Рычаг_для_стены.flag3;
        }

        else
        {
            lever.transform.eulerAngles = new Vector3(0, 0, 45f);
            Рычаг_для_стены.flag2 = !Рычаг_для_стены.flag2;
            Рычаг_для_стены.flag3 = !Рычаг_для_стены.flag3;
        }

        if (Рычаг_для_стены.flag2)
            Стена2.transform.position += new Vector3(0, 20f, 0);
        else
            Стена2.transform.position += new Vector3(0, -20f, 0);
        if (Рычаг_для_стены.flag3)
            Стена3.transform.position += new Vector3(0, 20f, 0);
        else
            Стена3.transform.position += new Vector3(0, -20f, 0);
    }
}

