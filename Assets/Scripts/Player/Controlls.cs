using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    //Character Controller.
    public CharacterController controller { get; private set; }

    //Direções no Teclado.
    public float directionX { get; set; }
    public float directionZ { get; set; }

    //Mouse.
    //Mouse Sensitivity.
    public float mouseSensitivity { get; private set; } = 100f;

    //Mouse X,Y.
    public float mouseX { get; set; }
    public float mouseY { get; set; }

    //Mouse Fire1, Fire2.
    public float fire1 { get; set; }
    public bool mouseButton1Up { get; set; }
    public bool mouseButton1Down { get; set; }
    public float fire2 { get; set; }
    public bool mouseButton2Up { get; set; }
    public bool mouseButton2Down { get; set; }


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal");
        directionZ = Input.GetAxisRaw("Vertical");

        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
       
        fire1 = Input.GetAxis("Fire1");
        mouseButton1Up = Input.GetButtonUp("Fire1");
        mouseButton1Down = Input.GetButtonDown("Fire1");

        fire2 = Input.GetAxis("Fire2");
        mouseButton2Up = Input.GetButtonUp("Fire2");
        mouseButton2Down = Input.GetButtonDown("Fire2");
    }


}
