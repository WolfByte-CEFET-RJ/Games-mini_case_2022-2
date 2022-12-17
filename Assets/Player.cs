using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private bool onAir;

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
        
    }
}

