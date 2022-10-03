using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControlaArma : MonoBehaviour
{


    public GameObject CanoDaArma;
    public GameObject bala;
    //Vector3 correction;


    void Start()
    {
        //correction = new Vector3(-0.065f, 0.34f, 2f); 
        //Ver Melhor.
    }

    public void Shoot()
    {

        if (Input.GetAxis("Fire1") == 1)
        {
            Instantiate(bala, CanoDaArma.transform.position, CanoDaArma.transform.rotation);
        }

    }

    /*
    private void Atirar()
    {
        movimento.MoveRotation();
    }


     */
}
