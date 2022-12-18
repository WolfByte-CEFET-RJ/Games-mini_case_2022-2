using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private bool onAir;
    [SerializeField] private Transform gameOver;

    Rigidbody2D Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        jumpSpeed = 900f;
        onAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;  
        }else
        {
            gameOver.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
        
    }

    void RetryGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

}