using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonagem : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigid;
    [SerializeField] Vector2 poder;

    public void pulin()
    {
        rigid.velocity = Vector2.zero;
        rigid.AddForce(poder, ForceMode2D.Impulse);
    }








       
}
