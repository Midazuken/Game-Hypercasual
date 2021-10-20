using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonagem : MonoBehaviour
{
    private Rigidbody2D _rigid;
    [SerializeField] Vector2 poder;

    public void pulin()
    {
        _rigid.velocity = Vector2.zero;
        _rigid.AddForce(poder, ForceMode2D.Impulse);

    }

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }








}
