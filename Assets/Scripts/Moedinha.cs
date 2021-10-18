using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedinha : MonoBehaviour
{
    public int Pontos;
    public GameObject PegarMoeda;
   

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(PegarMoeda, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            //Destroy(gameObject);
            gameObject.SetActive(false);

            Pause.stay.AllPontos += Pontos;
            Pause.stay.AlterandoPontos();
        }
        
    }


}
