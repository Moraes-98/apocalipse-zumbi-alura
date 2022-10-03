using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    internal bool Vivo { get; set; } = true;
    internal int Vida { get; set; } = 5;

    // Start is called before the first frame update
    void Start()
    {
 //       Vida = 5;
    }

    // Update is called once per frame
    void Update()
    {
        print(Vida);
        //Contagem de Vida

        if(Vida == 0)
        {
            Vivo = false;
        }
        
    }


}
