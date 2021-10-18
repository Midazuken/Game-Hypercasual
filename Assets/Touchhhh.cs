using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touchhhh : MonoBehaviour
{
    [SerializeField] private GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch[] touches = Input.touches;

        foreach (Touch tc in touches)
        {
            player[tc.fingerId].transform.position = tc.position;
        }
        
    }
}
