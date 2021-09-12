using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar1Normal : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = (BOtWalk1Normal.healthpoint)/1000;
        transform.localScale = localScale;
    }
}
