using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public void LoadScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

    public Text Pontinhos;
    public int AllPontos;

    public static Pause stay;

     void Start()
    {
        stay = this;

    }

    public void AlterandoPontos()
    {
        Pontinhos.text = AllPontos.ToString();
    }

}
