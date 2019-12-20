using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float speed = 1.0f;

    private void Update()
    {
        #region translate
        // float translateX = Input.GetAxis("Horizontal") * speed;
        // float translateY = Input.GetAxis("VerticalY") * speed;
        // float translateZ = Input.GetAxis("Vertical") * speed;

        // //transform.Translate(translateX, 0, 0);
        // //transform.Translate(0, translateY, 0);
        // //transform.Translate(0, 0, translateZ);

        // transform.position = new Vector3(transform.position.x + translateX,
        //                                 transform.position.y + translateY,
        //                                 transform.position.z + translateZ);

        //// transform.Translate(translateX, translateY, translateZ);
        #endregion

        float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed;
        float rotationZ = Input.GetAxis("HorizontalZ") * rotationSpeed;
        float translateZ = Input.GetAxis("VerticalY") * rotationSpeed;

        transform.Rotate(rotationX, 0, 0);
        transform.Rotate(0, rotationY, 0);
        transform.Rotate(0, 0, rotationZ);
        transform.Translate(0, 0, translateZ);

       // transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
