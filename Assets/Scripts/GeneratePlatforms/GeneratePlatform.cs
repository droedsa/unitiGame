using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject platformPrefab;       // переменная для префаба
    public float frequency;

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();    // нам нужен новый вектор

        for (int i = 0; i < frequency; i++)                
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);  // позиция по оси х
            SpawnerPosition.y += Random.Range(1f, 10f);      // позиция по оси у 

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);  // создание префабов
        }
    }

}
