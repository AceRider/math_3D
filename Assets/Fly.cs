﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float speed = 1.0f;

    private void Update()
    {
        float translateX = Input.GetAxis("Horizontal") * speed;
        float translateY = Input.GetAxis("VerticalY") * speed;
        float translateZ = Input.GetAxis("Vertical") * speed;

        //transform.Translate(translateX, 0, 0);
        //transform.Translate(0, translateY, 0);
        //transform.Translate(0, 0, translateZ);

        transform.position = new Vector3(transform.position.x + translateX,
                                        transform.position.y + translateY,
                                        transform.position.z + translateZ);

       // transform.Translate(translateX, translateY, translateZ);
    }
}
