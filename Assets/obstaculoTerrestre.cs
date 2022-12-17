using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculoTerrestre : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        this.gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
