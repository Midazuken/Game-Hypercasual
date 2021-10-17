using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    [SerializeField] private GameObject[] player;

    void Start()
    {

    }


    void Update()
    {
        Touch[] touches = Input.touches;

        foreach (Touch dedo in touches)
        {
            
            player[dedo.fingerId].transform.position = dedo.position;

        }
    }
}
