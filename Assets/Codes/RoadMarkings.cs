using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMarkings : MonoBehaviour
{
    public GameObject BulletSlow;
    public GameObject BulletStop;
    
    public Transform WaypointsL;
    public Transform WaypointsR;

    public float time;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            fireB();
        }
    }

    private IEnumerator fireB()
    {
        while (true)
        {
            Instantiate(BulletSlow, WaypointsL.position, WaypointsL.rotation);
            Instantiate(BulletSlow, WaypointsR.position, WaypointsR.rotation);
            
            yield return new WaitForSeconds(time);
            
            Instantiate(BulletStop, WaypointsL.position, WaypointsL.rotation);
            Instantiate(BulletStop, WaypointsR.position, WaypointsR.rotation);
        }
    }
}
