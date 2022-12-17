using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    
    private float segundos;
    private float segundosTotais;
    private bool ativado;
    [SerializeField] private GameObject obstaculo;
    
    void Start()
    {
        ativado = true;
        segundosTotais = 2f;
        segundos = segundosTotais;
    }

    // Update is called once per frame
    void Update()
    {
        segundos -= Time.deltaTime;
        if(segundos <= 0)
        {
            gerar();
            segundos = segundosTotais;
        }
        
    }

    private void gerar()
    {   
        if(ativado)
        {
                Debug.Log("Invocou");
                Instantiate(obstaculo, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
        }
    }
}
