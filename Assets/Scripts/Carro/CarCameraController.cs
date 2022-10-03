
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCameraController : MonoBehaviour
{
    public Transform playerTransform;
    float mouseSensitivity = 500f;
    
    float distanceZ = -5;
    float distanceX = 1;
    float distanceY = 2;
    float inputY = 50f;
    float inputX = 0f;

    Vector3 offsetDistance;
    Quaternion newRotation;
    


    void start()
    {
        transform.forward = playerTransform.forward;
    }


    void Update()
    {
        inputY += Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        inputX += Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        if (Input.GetAxis("Fire2") == 1)
        {
            distanceZ = -3.5f;
            distanceY = 2.5f;   
        }
        else
            distanceZ = -6f;


        offsetDistance = new Vector3(distanceX, distanceY, distanceZ);
        newRotation = Quaternion.Euler(-inputY, inputX, 0f);

        transform.position = playerTransform.position + newRotation * offsetDistance;

        transform.rotation = newRotation;
    }


    void FixedUpdate()
    {

    }


}