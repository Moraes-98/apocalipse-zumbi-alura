using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject controlaArma;
    public GameObject canvas;
    internal Status status;
    float vida;
    Controlls controlls;
    Movimento movimento;
    Animations animations;
    ControlaArma shoot;

    Rigidbody rb;
    


    void Start()
    {
        Time.timeScale = 1;

        status = GetComponent<Status>();
        controlls = GetComponent<Controlls>();
        movimento = GetComponent<Movimento>();
        animations = GetComponent<Animations>();    
        shoot = GetComponent<ControlaArma>();

        rb = GetComponent<Rigidbody>();
        
    }


    void FixedUpdate()
    {
        vida = status.Vida;


        //Mirar e Atirar.
        if (controlls.mouseButton2Down == true)
        {
            movimento.MiraRotation();

            //  controlls.mouseButton2Down = false;
        }
        
        if (controlls.fire1 == 1)
        {
            //Atirar(); - Movimentar ao atirar (Está na Classe ControlaArma)

            shoot.Shoot();
        }
        
        //Move.
        movimento.Move();
    }


    private void LateUpdate()
    {
        animations.GetAnimationWalk();
    }

    public float GetStatus()
    {
        return vida;
    }
}
