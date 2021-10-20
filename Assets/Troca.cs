using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca : MonoBehaviour
{
    public GameObject deitadin;
    public GameObject correndin;

    public void Deitar()
    {
        correndin.SetActive(false);
        deitadin.SetActive(true);
        Invoke("Activate", 0.75f);

    }

    void Activate()
    {
        deitadin.SetActive(false);
        correndin.SetActive(true);
    }
   
}
