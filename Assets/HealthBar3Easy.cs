using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar3Easy : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = (BotWalk3Easy.healthpoint)/1000;
        transform.localScale = localScale;
    }
}
