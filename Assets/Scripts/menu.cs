using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.scenemanagment;

public class menu : MonoBehaviour
{
    [header("Batata")]
    public gameObject   painel;
    
}

public void Saida(void) 
{
    Application.Quit;
}

public void LoadScene(string scenename)
{
    StartCoroutine(LoadScene(scenename));
}