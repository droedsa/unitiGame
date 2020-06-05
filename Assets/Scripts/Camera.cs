﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera: MonoBehaviour
{
    public Transform doodlePos; // позиция дудлика

    void Update()
    {
        if (doodlePos.position.y > transform.position.y) // если позиция дудлика больше позициии камеры
        {
            // то позиция камеры приравнивается к позиции дудлика
            transform.position = new Vector3(transform.position.x, doodlePos.position.y, transform.position.z);
        }
    }
}
