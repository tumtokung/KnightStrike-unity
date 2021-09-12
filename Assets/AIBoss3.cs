using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBoss3 : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float hp=300;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    public Transform player;
    public GameLogic control;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    void Update()
    {

        if(Vector2.Distance(transform.position,player.position) > stoppingDistance){
            transform.position = Vector2.MoveTowards(transform.position,player.position,speed*Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position,player.position) < stoppingDistance && Vector2.Distance(transform.position,player.position) > retreatDistance){
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position,player.position) < retreatDistance){
            transform.position = Vector2.MoveTowards(transform.position,player.position, -speed*Time.deltaTime);
        }

        if(timeBtwShots <= 0){
            Instantiate(projectile, transform.position , Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else{
            timeBtwShots -=Time.deltaTime; 
        }
        if(Input.GetKey(KeyCode.Z)){
            hp=0;
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "fireball_02 (1)(Clone)")
        {

            TakeDamage(10);
        }
        if(other.gameObject.name == "slashMan(Clone)")
        {

            TakeDamage(15);
        }
        if(hp <= 0){
            Destroy(this.gameObject);
            control.isGameBoss3 = true;
        }
        
    }
     void TakeDamage(int damage){
        hp -=damage;
    }
    void OnGUI()
    {
      GUI.backgroundColor = Color.red;
      GUI.Button(new Rect(30,450,(500*1.9f),20),"");
      GUI.Button(new Rect(30,450,((hp*1.67f)*1.9f),20),hp.ToString());
    }
}