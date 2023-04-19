using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{

    private float segundos;
    private float segundosTotais;
    private bool ativado;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private GameObject obstaculoB;
    
    void Start()
    {
        ativado = true;
        segundosTotais = 3f;
        segundos = segundosTotais;
    }

    // Update is called once per frame
    void Update()
    {
        segundos -= Time.deltaTime;
        if(segundos <= 0)
        {
            gerar();
            if(segundosTotais > 1.3f)
            {
                segundosTotais -= 0.05f;
            }
            segundos = segundosTotais;
            
        }
        
    }

    private void gerar()
    {   
        
        int tipo = (int)Random.Range(1f, 3f);
        if(ativado)
        {
            Debug.Log(tipo);
            switch(tipo)
            {
                case 1:
                    Instantiate(obstaculo, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
                    break;
                case 2:
                     Instantiate(obstaculoB, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
                    break;
                default:
                    break;
            }
                
        }
    }
}
