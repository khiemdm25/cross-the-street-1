/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingCar : MonoBehaviour
{
    public GameObject CarPrefab;
    public int poolSize;
    private Queue<GameObject> pool;

    private void Awake()
    {
        pool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(CarPrefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }

    public GameObject GetCar()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            // Tạo thêm xe nếu cần
            GameObject obj = Instantiate(CarPrefab);
            return obj;
        }
    }

    public void ReturnCar(GameObject car)
    {
        if (pool.Count < poolSize) // Kiểm tra kích thước hàng đợi
        {
            car.SetActive(false);
            pool.Enqueue(car);
        }
        else
        {
            Destroy(car); // Nếu pool đã đầy, hủy đối tượng
        }
    }
}*/