using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreativeCar : MonoBehaviour
{
    public int width = 20;
    public int height = 7;
    public float spacing = 1.5f; // Khoảng cách giữa các ô trên trục X

    public int rotation;
    public GameObject[] carPrefab;
    private GameObject[,] cars;
    
    public Vector2 frameOffset; // Biến để điều chỉnh vị trí khung
    public float xOffset = 0.0f; // Khoảng cách bổ sung nếu cần

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
        UpdateCarPositions();
    }
    
    void Update() { }

    void InitializeBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Tạo xe ngẫu nhiên với xác suất 50%
                if (Random.value > 0.5f) // Bạn có thể điều chỉnh xác suất này
                {
                    CreateCar(x * spacing, y); // Tạo xe với khoảng cách chỉ trên trục X
                }
            }
        }
    }

    void CreateCar(float x, float y)
    {
        int getcar = Random.Range(0, carPrefab.Length);
        GameObject selectedCarPrefab = carPrefab[getcar];
    
        GameObject newCar = Instantiate(selectedCarPrefab); 
        newCar.transform.position = new Vector2(x, y); // Sử dụng tọa độ đã điều chỉnh
    
        // Xoay xe sang phải
        newCar.transform.rotation = Quaternion.Euler(0, 0, rotation); 
        cars[(int)(x / spacing), (int)y] = newCar; // Lưu xe vào mảng
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow; // Đặt màu cho khung

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Vẽ khung cho các ô nơi xe được tạo ra
                Vector3 position = new Vector3(x * spacing + frameOffset.x, y + frameOffset.y, 0);
                Gizmos.DrawWireCube(position, new Vector3(1, 1, 0)); // Kích thước 1x1
            }
        }
    }

    public void UpdateCarPositions()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (cars[x, y] != null) // Kiểm tra xem xe có tồn tại
                {
                    // Cập nhật vị trí xe đến vị trí khung vàng với xOffset
                    Vector2 newPosition = new Vector2(x * spacing + frameOffset.x + xOffset, y + frameOffset.y);
                    cars[x, y].transform.position = newPosition;
                }
            }
        }
    }
}