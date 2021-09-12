﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar2Normal : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = (Botwalk2Normal.healthpoint)/1000;
        transform.localScale = localScale;
    }
}
