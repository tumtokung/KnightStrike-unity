using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySlash : MonoBehaviour
{
    public float speed = 12f;
    public float secondDes =1f; 
    float StartTime;
    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed *Time.deltaTime);
        if(Time.time - StartTime >= secondDes)
        {
            Destroy(this.gameObject);
        }
    }
}
