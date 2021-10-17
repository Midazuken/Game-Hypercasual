using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedinha : MonoBehaviour
{
    public int Pontos;
   

    void OnTriggerEnter2D(Collider2D moedinha)
    {
        if(moedinha.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            Pause.stay.AllPontos += Pontos;
            Pause.stay.AlterandoPontos();
        }
        
    }


}
