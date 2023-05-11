using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour
{
     private Player jogador;
   
    void Start()
    {
        jogador = GameObject.Find("Player").GetComponent<Player>();
    }

    
    void Update()
    {
        if(transform.position.x <= jogador.transform.position.x - 5 )
         {
            Destroy(this.gameObject);
            
         }
    }
}
