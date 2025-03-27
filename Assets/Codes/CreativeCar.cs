using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreativeCar : MonoBehaviour
{
    public int width = 20;
    public int height = 7;

    public int rotation;
    public GameObject[] carPrefab;
    private GameObject[,] cars;


    private void Awake()
    {
        if (carPrefab == null || carPrefab.Length == 0)
        {
            Debug.LogError("Car prefabs chưa được gán!");
            return;
        }
        
        cars = new GameObject[width, height];
        InitializeBoard();
    }

    void Start()
    {
        
    }
    

    void Update()
    {
        
    }

    void InitializeBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x % 2 == 0 && y % 2 == 0) // Ví dụ: chỉ tạo ở ô chẵn
                {
                    CreateCar(x, y);
                }
            }
        }
    }

    void CreateCar(int x, int y)
    {
        int getcar = Random.Range(0, carPrefab.Length);
        GameObject selectedCarPrefab = carPrefab[getcar];
        
        GameObject newCar = Instantiate(selectedCarPrefab); 
        newCar.transform.position = new Vector2(x, y); 
        
        // Xoay xe sang phải (hướng từ trái sang phải)
        newCar.transform.rotation = Quaternion.Euler(0, 0, rotation); // Góc 0 độ (trục X dương)
        
        cars[x, y] = newCar; 
    }
}