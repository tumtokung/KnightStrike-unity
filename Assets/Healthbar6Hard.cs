using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar6Hard : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = (BOtwalk6Hard.healthpoint)/1000;
        transform.localScale = localScale;
    }
}