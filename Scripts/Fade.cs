﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    public void Fader()
    {
        GetComponent<Animator>().SetBool("fade", true);
    }


}
