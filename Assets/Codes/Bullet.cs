using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;

    public float timeDelete;
    private float cound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * moveSpeed;
        
        cound += Time.deltaTime;
        if (cound >= timeDelete)
        {
            Destroy(this.gameObject);
        }
    }
}
