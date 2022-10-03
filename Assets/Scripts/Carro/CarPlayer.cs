using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlayer : MonoBehaviour
{

    float velocity = 500f;
    public float turnTime = 0.1f;

    public float lenghtRay;
    private Camera cam;
    Transform cameraTransform;

    private Vector3 direction;
    private CharacterController controller;

    

    private float turnVelocity;


    Vector3 directionMove;
   
    Rigidbody rb;
    float speed = 1;


    float torque = 100;
    

    float inputX;
    float inputZ;

    float magnitude;
    float targetAngle;
    float angle;




    void Start()
    {
        cam = Camera.main;
        cameraTransform = cam.transform;

        
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

     
    }


    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");
       // mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        direction = new Vector3(inputX, 0f, inputZ).normalized;
    }


    void FixedUpdate()
    {
        //Physics.
        //RayCast();
        //Gravity();


        
        //Move n' Rotation.
        
        if (direction.magnitude >= 0.1f)
        {
            Move();

        }
        

        if (rb.velocity != Vector3.zero)
        {
            Rotation(turnTime);
        }

      

    }







    //O que está abaixo será colocado em classes diferentes para depois serem puxados para esse código principal.


    //MOVIMENTAÇAO, ROTAÇÃO E MIRA.

    private void Move()
    {
        //Vector3 forward = transform.TransformDirection(Vector3.forward);

        //rb.MovePosition(rb.position + rb.transform.forward * velocity * Time.deltaTime); - Com DeltaTime da até pra fazer derrapagem

        //rb.MovePosition(transform.position + direction * Time.deltaTime * -speed);


        rb.MovePosition(rb.position + transform.forward * speed * Time.deltaTime);

        //rb.AddForce(Vector3.back * speed, ForceMode.Force);
        //rb.AddForceAtPosition(Vector3.forward, direction);
        //rb.AddRelativeTorque(Vector3.up * torque * inputZ);

    }


    private void Rotation(float velocity)
    {
        //Convert radians to angle.
        targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
        angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnVelocity, velocity);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }




    //FÍSICA.
    /*
    void RayCast()
    {
        isGrounded = false;
        RaycastHit hit;
        if(Physics.Raycast(rayPoint.position, Vector3.down, out hit, lenghtRay, layerGround))
        {
            isGrounded = true;
        }
    }


    void Gravity()
    {
        if (isGrounded)
        {
            verticalVel = 0;
        }
        else
            verticalVel -= 3f * Time.deltaTime;

        directionMove = new Vector3(0, verticalVel, 0);
        controller.Move(directionMove);
    }

    */

}
