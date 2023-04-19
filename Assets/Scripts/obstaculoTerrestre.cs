using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculoTerrestre : MonoBehaviour
{
    private float speed;
    public GameObject player;
    private Player jogador;
    private bool pontoColetado;
    // Start is called before the first frame update
    void Start()
    {
        pontoColetado = true;
        jogador = GameObject.Find("Player").GetComponent<Player>();
        speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
         if(jogador.transform.position.x > transform.position.x && pontoColetado)
         {
            pontoColetado = false;
            jogador.pontuacao += 50;
         }
         
    }
    

    void FixedUpdate()
    {
        

        this.gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}