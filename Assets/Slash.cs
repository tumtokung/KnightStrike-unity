using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public float speed;
    public float secondDes =6f; 
    float StartTime;

    private Transform player;
    private Vector2 target; 

    void Start()
    {
        StartTime = Time.time;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x,player.position.y);
        
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,player.position,speed*Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y){
            DestroyProjecttile();
        }
        if(Time.time - StartTime >= secondDes)
        {
            DestroyProjecttile();
        }
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            DestroyProjecttile();
        }
    }

    void DestroyProjecttile(){
        Destroy(this.gameObject);
    }
}
