using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed;//change speed
    public float jump;
    private float move;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//assign rb to rigidbody on player 
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
       
    }
}
