using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СоздательШариков : MonoBehaviour
{
    public GameObject Square;
    public float SquareVelocity = 2f;
    // Update is called once per frame
    void Update()
    {
        if (Кнопка.flag == 1)
        {
            GameObject newSquare = Instantiate(Square, transform.position, transform.rotation);
            Кнопка.flag = 0;
        }

    }
}
