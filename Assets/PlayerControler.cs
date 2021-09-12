using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float AttackRate = 0.1f;
    public float FireRate = 0.1f;
    public float speed;
    public GameObject HitArea;
    public GameObject Slash;
    public GameLogic control;
    private float nextAttack = 0.0f;
    float block=0;
    float x,sx,y,sy;
    bool atk;
    Animator am;
    Rigidbody2D rb;
    public float healthBar = 100f,stamina = 100f;


    void Start()
    {
        //Time.timeScale = 1;

        am = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sx = transform.localScale.x;
        sy = transform.localScale.y;
    }
    void Update()
    {
        //logic
        if(stamina < 100){
          stamina += Time.deltaTime*3;
        }


        // Attack p
        am.SetBool("IsAttack",false);
        am.SetBool("IsCast",false);
        am.SetBool("IsBlock",false);
        x = Input.GetAxis("Horizontal");
        am.SetFloat("IsWalk",Mathf.Abs(Input.GetAxis("Horizontal")));
        y = Input.GetAxis("Vertical");
        am.SetFloat("IsWalkY",Abs2(y));
        rb.velocity = new Vector2 (rb.velocity.x ,y * speed);
        
        if(Input.GetKey(KeyCode.P) && Time.time > nextAttack && stamina >= 16 )
        {
          am.SetBool("IsAttack",true);
          nextAttack = Time.time + AttackRate;
          stamina -=15; 
          slash();
        }
         // Attack cast fire
        else if(Input.GetKey(KeyCode.O) && Time.time > nextAttack && stamina >= 11)
        {
          am.SetBool("IsCast",true);
          nextAttack = Time.time + FireRate;
          stamina = stamina-10;
          fire();
        }
        // Block Attack 
        else if(Input.GetKey(KeyCode.I) )
        {
          am.SetBool("IsBlock",true);
          block =5;
        }
        // x move
        else if(x < -0.1f){
          transform.Translate(Vector2.right * speed * Time.deltaTime);
          transform.eulerAngles = new  Vector2(0,180);
          am.SetBool("IsDash",false);
          if(Input.GetKey("space") && stamina >= 5 )
          {
            am.SetFloat("IsWalk",0);
            transform.Translate(Vector2.right * speed * Time.deltaTime*3);
            am.SetBool("IsDash",true);
            stamina -=2;
          }
        }

        else if(x > 0.1f){
          transform.Translate(Vector2.right * speed * Time.deltaTime);
          transform.eulerAngles = new  Vector2(0,0);
          am.SetBool("IsDash",false);
          if(Input.GetKey("space")&& stamina >= 5 )
          {
            am.SetFloat("IsWalk",0);
            transform.Translate(Vector2.right * speed * Time.deltaTime*3);
            am.SetBool("IsDash",true);
            stamina -=2;
          }
        }
        // y move
        else if(y > 0)
        {
          transform.localScale = new Vector3 (transform.localScale.x,sy,transform.localScale.z);
        }
        else if(y < 0)
        {
          transform.localScale = new Vector3 (transform.localScale.x,sy,transform.localScale.z);
        }
        else{
          block =0;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Monster")
        {

            healthBar =healthBar-10 + block ;
            if(healthBar <=0){
            healthBar = 0;
            am.SetTrigger("Death");
            StartCoroutine(WaitDeath());
          }
        }
        if(other.gameObject.name == "slash(Clone)")
        {

            healthBar =healthBar-10 + block ;
            if(healthBar <=0){
            healthBar = 0;
            am.SetTrigger("Death");
            StartCoroutine(WaitDeath());
          }
        }
        if(other.gameObject.name == "slash2(Clone)")
        {

            healthBar =healthBar-10 + block ;
            if(healthBar <=0){
            healthBar = 0;
            am.SetTrigger("Death");
            StartCoroutine(WaitDeath());
          }
        }
        if(other.gameObject.name == "slash3(Clone)")
        {

            healthBar =healthBar-10 + block ;
            if(healthBar <=0){
            healthBar = 0;
            am.SetTrigger("Death");
            StartCoroutine(WaitDeath());
          }
        }
    }
    IEnumerator WaitDeath(){
      yield return new WaitForSeconds(2);
      control.isGameOver=true;
    }

    float Abs2(float y){
      return y >= 0f ? -y : y;
    }

    void fire(){
      Instantiate(HitArea,transform.position,transform.rotation);
    }
    void slash(){
      Instantiate(Slash,transform.position,transform.rotation);
    }

    void OnGUI()
    {
      GUI.backgroundColor = Color.red;
      GUI.Button(new Rect(Screen.width-(Screen.width-100),10,(healthBar*2),20),healthBar.ToString());
      GUI.backgroundColor = Color.yellow;
      GUI.Button(new Rect(Screen.width-(Screen.width-100),30,(stamina*2),20),stamina.ToString());
      GUI.Box(new Rect(100,50,55,25),"Knight");

      if(GUI.Button(new Rect(Screen.width-80,10,80,20),"Back"))
       {
           Application.LoadLevel("start");
       }
       if(GUI.Button(new Rect(Screen.width-80,30,80,20),"Quit")){
         Application.Quit(); 
       }
    }



}
