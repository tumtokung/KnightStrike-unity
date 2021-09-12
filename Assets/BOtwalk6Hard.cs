using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOtwalk6Hard : MonoBehaviour
{
    public static float healthpoint =100;

    public float speed;
    public Transform target;
    public GameObject HitArea;
    public GameLogic control;
    public float FireRate = 0.7f;
    private float nextAttack = 0.0f;
    Rigidbody2D rb,rigid;
    Animator am;
    float x;
    
    void Start()
    {
        am = GetComponent<Animator>();
        rigid = gameObject.GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 targetPosition = target.position;
        Vector2 botPosition = transform.position;
        Vector2 direction = targetPosition - botPosition;
        x = target.position.x - transform.position.x;
        
        if(Vector2.Distance(targetPosition,botPosition) > 15){
            rigid.velocity = direction.normalized*speed; 
        }
        

        if(rb.velocity.x > 0){
            transform.localScale = new  Vector2(1,1);
        }
        else{
            transform.localScale = new  Vector2(-1,1);
        }

        if(Mathf.Abs(x) < 10   && Time.time > nextAttack){
            nextAttack = Time.time + FireRate;
            //fire();
        }
    
    }

    void fire(){
      Instantiate(HitArea,transform.position,transform.rotation);
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
        if(other.gameObject.name == "Man")
        {
            
            Destroy(this.gameObject);
        }
    
        if(healthpoint <= 0){
            Destroy(this.gameObject);
            control.isGameWin3 = true;
        }
    }

    void TakeDamage(int damage){

        healthpoint -=damage;
        
    }
    
}