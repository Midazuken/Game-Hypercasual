using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPassarin : Loop
{

    [SerializeField] private Vector2 randomHeight;


   void Start()
    {

        
        


        onfundoloop += OnPassarinLoop;
        foreach (Transform passarin in fundos)
        {

            DoRandomHeight(passarin);
           
        }

    }

    void DoRandomHeight(Transform passarin)
    {

        float randomValue = Random.Range(randomHeight.x, randomHeight.y);
        passarin.position = new Vector2(passarin.position.x, randomValue);
       

    }

    void OnPassarinLoop(Transform passarin)
    {

        DoRandomHeight(passarin);
        gameObject.SetActive(true);


    }





}
    
