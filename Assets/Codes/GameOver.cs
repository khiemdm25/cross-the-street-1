using System;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOveroj;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            other.gameObject.SetActive(false);
            gameOveroj.SetActive(true);
        }
    }
}
