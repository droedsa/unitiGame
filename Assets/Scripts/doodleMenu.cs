using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodleMenu : MonoBehaviour
{
    public static doodleMenu instance;
    public GameObject other;
    public Rigidbody2D DoodleMenuRigid;
    void Start()
    {
        if (instance == null)                               // пишем эти строчки, чтоб можно было корректно использовать переменные в других скриптах
        {
            instance = this;
        }
    }
}
