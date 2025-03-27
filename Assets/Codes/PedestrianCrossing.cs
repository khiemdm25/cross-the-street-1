using System;
using UnityEngine;

public class PedestrianCrossing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(""))
        {
            signal();
        }
    }

    void signal()
    {
        
    }
}
