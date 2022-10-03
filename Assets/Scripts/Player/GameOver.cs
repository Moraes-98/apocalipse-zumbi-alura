using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject Jogador;
    public GameObject RawImage;
    public GameObject Text;

    Player scriptJogador;



    void Start()
    {
        scriptJogador = Jogador.GetComponent<Player>();
    }


    void Update()
    {
        if (scriptJogador.status.Vivo == false)
        {
            //scriptJogador.canvas.;
            Time.timeScale = 0;

            RawImage.SetActive(true);
            Text.SetActive(true);

            //Dobradiça Articulação = GetComponentInParent(typeof( HingeJoint )) as HingeJoint 
            //.activeInHierarchy("RawImage");
            //.active("RawImage");

            //GameObject.Find("Text (Legacy)").SetActive(true);
            //scriptJogador.canvas.FindWithTag("GameOver").SetActive(true); 
            //Preciso Conseguir acessar o texto e o fundo para ativa-los quando o personagem morrer.
        }

    }
}
