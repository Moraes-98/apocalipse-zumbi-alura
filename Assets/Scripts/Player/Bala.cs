using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour 
{
    //public GameObject CanoDaArma;

    public float Velocidade = 20;

	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position + 
            transform.forward * Velocidade * Time.deltaTime);
	}

    void OnTriggerEnter(Collider colliderObject)
    {
        if(colliderObject.tag == "Guns")
        {
            print("Destruiu");
        }
        else if(colliderObject.tag == "Inimigo")
        {
            Destroy(colliderObject.gameObject);
        }
        Destroy(gameObject);

    }

}
