using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMoedinha : Loop
{

    [SerializeField] private Vector2 rHeight;
    public GameObject Moedin;

    void Start()
    {
      

        onfundoloop += OnPassarinLoop;
        foreach (Transform moedinha in fundos)
        {

            DoRandomHeight(moedinha);
            Moedin.SetActive(true);

        }

    }

    void DoRandomHeight(Transform moedinha)
    {

        float randomValue = Random.Range(rHeight.x, rHeight.y);
        moedinha.position = new Vector2(moedinha.position.x, randomValue);


    }

    void OnPassarinLoop(Transform moedinha)
    {

        DoRandomHeight(moedinha);
        gameObject.SetActive(true);


    }

    

}
