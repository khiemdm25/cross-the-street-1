using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMarkings : MonoBehaviour
{
    public GameObject BulletSlow;
    public GameObject BulletStop;
    
    public Transform WaypointsL;
    public Transform WaypointsR;
    
    public float timer = 1f;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FireBullets()); // Khởi động coroutine
        }
    }

    private IEnumerator FireBullets()
    {
        // Tạo viên đạn chậm
        Instantiate(BulletSlow, WaypointsL.position, WaypointsL.rotation);
        Instantiate(BulletSlow, WaypointsR.position, WaypointsR.rotation);
        
        // Chờ 1 giây
        yield return new WaitForSeconds(timer);
        
        // Tạo viên đạn dừng lại
        Instantiate(BulletStop, WaypointsL.position, WaypointsL.rotation);
        Instantiate(BulletStop, WaypointsR.position, WaypointsR.rotation);
    }
}