using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    public int countdow = 3;
    
    public int score;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // Moving();
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.CompareTag("bien"))
        // {
        //     turn();
        // }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("car"))
        {
            Time.timeScale = 0;
        }
        
    }

    void turn()
    {
        transform.Rotate(0, 0, 180);
    }

    // void Moving()
    // {
    //     if (Input.GetKey(KeyCode.Space))
    //     {
    //         rb.linearVelocity = Vector2.up * moveSpeed;
    //     }
    //     else
    //     {
    //         rb.linearVelocity = Vector2.zero;
    //     }
    // }


    public void congdiem(int count)
    {
        countdow += count;
    }

    public void trudiem(int count)
    {
        countdow -= count;
    }
    
}
