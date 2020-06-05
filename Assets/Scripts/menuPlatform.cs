using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPlatform : MonoBehaviour
{
    public float forceJump;                                         // переменная для силы прыжка
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)           // столкновения
    {

        if (collision.relativeVelocity.y < 0)                       // если относительная скорость меньше 0, ну вниз летит короче
        {
            doodleMenu.instance.DoodleMenuRigid.velocity = Vector2.up * forceJump;  // добавляем прыжок к переменной из скрипта "Doodle"
            GetComponent<AudioSource>().Play();
        }
    }
}
