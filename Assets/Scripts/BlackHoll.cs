using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoll : MonoBehaviour
{
    public GameObject BlackHole;
    public GameObject DoodleObj;



    public void OnCollisionEnter2D(Collision2D collision)       // столкновение объекта
    {
            Destroy(gameObject);                  // то уровень перезагружается
        
    }
}
