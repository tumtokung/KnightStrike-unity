using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayBulletBot : MonoBehaviour
{
    public float speed = 15f;
    public float secondDes =1f; 
    float StartTime;

    void Start()
    {
        StartTime = Time.time;
    }

    void Update()
    {
        transform.Translate(Vector2.right*speed *Time.deltaTime);
        if(Time.time - StartTime >= secondDes)
        {
            Destroy(this.gameObject);
        }
    }
}
