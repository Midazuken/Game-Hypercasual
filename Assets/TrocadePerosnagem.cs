using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocadePerosnagem : MonoBehaviour
{
    public GameObject deitadin;
    public GameObject playerzin;

    
    public void Deitar()
    {
        playerzin.SetActive(false);
        deitadin.SetActive(true);
        Invoke("Activate", 0.5f);

    }

    void Activate()
    {
        deitadin.SetActive(false);
        playerzin.SetActive(true);

    }
}
