
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera cam;
    public GameObject player;
    //float mouseSensitivity = 500f;
    
    float distanceZ;
    float distanceX;
    float distanceY;
    float inputY;
    float inputX;

    Vector3 offsetDistance;
    Quaternion newRotation;
    
    Controlls controlls;


    void Start()
    {
        cam = Camera.main;

        
        controlls = GetComponent<Controlls>();
    }



    void Update()
    {
        transform.forward = player.transform.forward;

        inputY += controlls.mouseY;
        inputX += controlls.mouseX;


        offsetDistance = new Vector3(distanceX, distanceY, distanceZ);
        newRotation = Quaternion.Euler(-inputY, inputX, 0f);

        transform.position = player.transform.position + newRotation * offsetDistance;
        transform.rotation = newRotation;


        if (controlls.fire2 == 1)
        {
            distanceZ = -5f;
            distanceY = 5f;


            //transform.rotation = Quaternion.FromToRotation(playerTransform.forward, transform.forward);
        }
        else
        {
            distanceZ = -12;
            distanceX = 2;
            distanceY = 5;
        }



    }



}