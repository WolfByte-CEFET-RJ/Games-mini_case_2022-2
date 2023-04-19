using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private bool onAir;
    [SerializeField] private Transform gameOver;
    [SerializeField] public float pontuacao;
    [SerializeField] private bool gameOn;
    [SerializeField] private float pointsPerSeconds;
    [SerializeField] private int vidas;
    private int maxVidas = 3;   

    Rigidbody2D Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {   
        gameOn = true;
        vidas = maxVidas;
        pointsPerSeconds = 13;
        Rigidbody = GetComponent<Rigidbody2D>();
        jumpSpeed = 1000f;
        onAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOn)
        {
            pontuacao += pointsPerSeconds * Time.deltaTime;
        }

        if(vidas <= 0)
        {
            fimDeJogo();
        }
        
    }

    void FixedUpdate()
    {
        JumpPlayer();
    }

    void JumpPlayer()
    {
        if(Input.GetKey(KeyCode.Space) && !onAir )
        {
            Rigidbody.AddForce(Vector3.up * jumpSpeed * Time.deltaTime, ForceMode2D.Impulse);
            onAir = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Plataforma")
        {
            onAir = false;
            Debug.Log("No Chão");
           
           
        }

        if(collision.gameObject.CompareTag("obstaculo"))
        {
            vidas--;
            Destroy(collision.gameObject);
            
        }
        
    }
    private void fimDeJogo()
    {
        gameOver.gameObject.SetActive(true);
        Time.timeScale = 0;
        gameOn = false;  
    }
    
    void RetryGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        vidas = maxVidas;
        pontuacao = 0;
        gameOn = true;
    }

}