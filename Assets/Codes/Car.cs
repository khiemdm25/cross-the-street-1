using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed;
    public float slowspeed;

    public Rigidbody2D rb;
    

    private float coutl;
    private float coutt;
    public float timeslow;
    public float timestop;
    
    public float timesDestroy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void FixedUpdate()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Slow"))
        {
            print("slow");
            
            speed *= slowspeed;
            coutl += Time.deltaTime;
            if (coutl >= timeslow)
            {
                speed /= timeslow;
                coutl = 0;
            }
        }
        if(other.gameObject.CompareTag("Stop"))
        {
            float newspeed = speed;
            speed *= 0;
            coutt += Time.deltaTime;
            if (coutt >= timestop)
            {
                speed = newspeed;
                coutt = 0;
            }
        }

        /*if (other.gameObject.CompareTag("PoollingC"))
        {
            FindObjectOfType<PoolingCar>().ReturnCar(gameObject); 
        }*/
    }
    
    

    public void destroyCar()
    {
        Destroy(gameObject, timesDestroy);
    }
    
    
    
}
