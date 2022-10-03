using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    //Câmera
    private Camera cam;

    //Controles
    Controlls controlls;
    float inputX;
    float inputZ;
    float mouseX;


    //Física e Movimento
    Rigidbody rb;
    Vector3 direction;
    Quaternion rotation;
    Quaternion rotBase;
    float velocityWalk = 0f;
    float turnVelocity;
    float targetAngle;
    float angle;
    float velRotation = 0.5f;
    bool mouseButton2;
    




    void Start()
    {
        cam = Camera.main;

        rb = GetComponent<Rigidbody>();
        controlls = GetComponent<Controlls>(); 
        
        //forward = transform.TransformDirection(Vector3.forward);
    }

    void Update()
    {
        inputX = controlls.directionX;
        inputZ = controlls.directionZ;
        mouseX = controlls.mouseX;
        mouseButton2 = controlls.mouseButton2Up;
        
        
        
        direction = new Vector3(inputX, 0f, inputZ).normalized;





        //Rotação Base
        if(mouseButton2 == true)
        {
            rotBase = new Quaternion();
            rotation[0] = 0;
            rotation[2] = 0;
            transform.rotation *= rotBase;
        }
        

    }

    public void Move()
    {

        if (direction.magnitude > 0.1f)
        {


            MoveRotation();


            
            rb.velocity = new Vector3(velocityWalk, velocityWalk, velocityWalk);
            rb.drag = 1000000;
            rb.MovePosition(rb.position + rb.transform.forward.normalized);

        }
        
      
    }


    public void MiraRotation()
    {
        // Vector3 relativePos = cam.transform.position + transform.position;
          //direction.x = mouseX;

          rotation = Quaternion.LookRotation(cam.transform.forward);
          transform.rotation = Quaternion.Slerp(transform.rotation, rotation, velRotation);

        //rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
    }


    
    public void MoveRotation() //float velocity 0.4f (Mirar)  0.1f (Padrão) 0.01f (Atirar)
    {
        velRotation = 0.4f;



        //Convert radians to angle.
        targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
        angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnVelocity, velRotation);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
    
}
