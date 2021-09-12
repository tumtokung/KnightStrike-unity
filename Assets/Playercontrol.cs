using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    public float jumpspeed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
          rb.velocity = new Vector2(rb.velocity.x,jumpspeed);
        }
    }
}
