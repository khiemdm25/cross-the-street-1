using System.Collections;
using UnityEngine;

public class SpamCar : MonoBehaviour
{
    public GameObject[] CarPrefab;
    public Transform Target;

    private float cout;
    public float times;
    public float twotimes; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(ABC());
    }

    // Update is called once per frame
    void Update()
    {
        settimespamcar();
    }

    void settimespamcar()
    {
        float getcar = Random.Range(times, twotimes);
        
        cout += Time.deltaTime;
        if (cout >= getcar)
        {
            setspamcar();
            cout = 0;
        }
    }

    void setspamcar()
    {
        
            int getcar = Random.Range(0, CarPrefab.Length);
            GameObject selectedCarPrefab = CarPrefab[getcar];
        
            Instantiate(selectedCarPrefab, Target.position, Target.rotation);
            
            
    }

    // IEnumerator ABC()
    // {
    //     settimespamcar();
    //     yield return new WaitForSeconds(1f);
    //     settimespamcar();
    // }
}
