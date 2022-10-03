using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VidaHUD : MonoBehaviour
{
    public GameObject ScriptPlayer;
    Player _scriptPlayer;

    float vida;
    float cont = 5;

    // Start is called before the first frame update
    void Start()
    {
        _scriptPlayer = ScriptPlayer.GetComponentInChildren<Player>();

        

    }

    // Update is called once per frame
    void Update()
    {
        print(_scriptPlayer.GetStatus());

        RectTransform rectTransform = GetComponent<RectTransform>();
        print(rectTransform.right);
        //rectTransform.right = new Vector3(700, 50, 0);
        //print(rectTransform.right);

        //rectTransform.transform.localScale -= new Vector3(9, 0, 10/(_scriptPlayer.GetStatus() * 60));

        vida = _scriptPlayer.GetStatus();

        while( vida < cont)
        {
            rectTransform.offsetMax -= new Vector2(40, 0);

            cont--;
        }
        
        //rectTransform.offsetMax -= new Vector2(1, 0);

        //rectTransform.right -= new Vector3(9, 0, (_scriptPlayer.GetStatus() / 60));
        print(rectTransform.right);
        print(_scriptPlayer.GetStatus());



        //Na vida ta saindo Referencia nula e mesmo assim o calculo nã fecha, talvez precise pensar até em outra forma de resolver isso.
        //Preciso que diminua a HUDvida (aumentando o valor do transform. conforme a vidaStatus for diminuindo. 
    }
}
