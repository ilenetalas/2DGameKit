﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
