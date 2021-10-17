using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loop : MonoBehaviour
{

    [SerializeField] protected Transform[] fundos;
    [SerializeField] private Vector2 speed;
    [SerializeField] private float width;
    private int _fundosLenght;
    protected System.Action<Transform> onfundoloop;
    
    void Start()
    {
        _fundosLenght = fundos.Length;
    }

    
    void Update()
    {
        
        foreach(Transform f in fundos)
        {
            f.Translate(speed * Time.deltaTime);

            if(f.position.x < width * _fundosLenght/2 * -1)
            {
                f.Translate(new Vector2(_fundosLenght * width, 0));
                onfundoloop?.Invoke(f);
            }
        }


    }
}
