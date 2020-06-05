using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;                          
using UnityEngine.UI;

public class Doodle : MonoBehaviour
{
    public static Doodle instance;                          

    public GameObject other;
    float horizontal;                                       // переменная для акселерометра
    public Rigidbody2D DoodleRigid;                         // публичный RB для дудлика
    private float topScore = 0.0f;

    public Text Score;


    void Start()
    {
        if (instance == null)                              
        {
            instance = this;
        }
    }


    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)    // если платформа Андроид
        {
            horizontal = Input.acceleration.x;                  // то подключаем акселерометр по оси х
        }

        if (Input.acceleration.x < 0)                           // если наклон акселерометра меньше нуля
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;    // то объект поворачивается налево
        }

        if (Input.acceleration.x > 0)                           // если наклон акселерометра больше нуля
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;     // то объект поворачивется направо
        }

        DoodleRigid.velocity = new Vector2(Input.acceleration.x * 10f, DoodleRigid.velocity.y);     //  добавляем силу к акселерометру, чтоб он не просто разворачивался в разные стороны
    }

    void Update()
    {
        if (DoodleRigid.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
            myText.mySore = topScore;
        }

        Score.text = "Score: " + Mathf.Round(topScore).ToString();
    }

    public void OnCollisionEnter2D(Collision2D collision)       // столкновение объекта
    {
        if (collision.collider.name == "DeadZone")              // если дудлик сталкивается с объектом с именем "DeadZone"
        {
            
            SceneManager.LoadScene(2);                          
        }

    }

}