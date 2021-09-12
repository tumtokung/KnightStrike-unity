using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthฺBarEasyBot2 : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = (BotWalk2Easy.healthpoint)/1000;
        transform.localScale = localScale;
    }
}
