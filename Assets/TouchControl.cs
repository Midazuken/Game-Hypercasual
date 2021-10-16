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
            if (dedo.phase == TouchPhase.Began)
            {
                player[dedo.fingerId].SetActive(true);
            }

            if (dedo.phase == TouchPhase.Canceled || dedo.phase == TouchPhase.Ended)
            {
                player[dedo.fingerId].SetActive(false);
                return;
            }

            player[dedo.fingerId].transform.position = dedo.position;

        }
    }
}
