using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar3Normal : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = (Botwalk3Normal.healthpoint)/1000;
        transform.localScale = localScale;
    }
}
