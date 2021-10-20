using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayer : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public Vector2 force;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void pulin()
    {
        myRigid.velocity = Vector2.zero;
        myRigid.AddForce(force, ForceMode2D.Impulse);
    }

}


