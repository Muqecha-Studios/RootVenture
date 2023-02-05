using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform point1;
    public Transform point2;

    public void SetStartPoint()
    {
        this.transform.position = point1.position;
    }

    public void patrol()
    {
        if (point1 == null || point2 == null)
            return;

        bool goingRight = true;


    }
}
