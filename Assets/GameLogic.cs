using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    float totalTime = 0;
    float TimeRemaining = 150f;
    //public int healthBar = 100,stamina = 100;
    public bool isGameOver = false;
    public bool isGameWin = false;
    public bool isGameBoss = false;
    public bool isGameWin2 = false;
    public bool isGameBoss2 = false;
    public bool isGameWin3 = false;
    public bool isGameBoss3 = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver){
            return;
        }
        if(isGameWin){
            return;
        }
        if(isGameBoss){
            return;
        }
        if(isGameWin2){
            return;
        }
        if(isGameBoss2){
            return;
        }
        if(isGameWin3){
            return;
        }
        if(isGameBoss3){
            return;
        }
        totalTime += Time.deltaTime;

        TimeRemaining -= Time.deltaTime;
        if(TimeRemaining <= 0){
            isGameOver = true;
        }

    }
    void OnGUI()
    {
      if(!isGameOver){
          GUI.Label(new Rect(Screen.width/2,10,Screen.width/4,Screen.height/5),"Time "+((int)TimeRemaining).ToString());

      }

      if(isGameOver){
          Time.timeScale = 0;
          GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Game Over!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"Restart"))
        {
           Application.LoadLevel("Stage1");
        }
        if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
        {
           Application.LoadLevel("start");
        }
      }
      if(isGameWin){
        Time.timeScale = 0;
        GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Next Boss!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"Boss Stage"))
            {
           Application.LoadLevel("Boss1");
            }
          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
            {
           Application.LoadLevel("start");
            }
        }
        if(isGameBoss){
        Time.timeScale = 0;
        GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Game Win!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"Next Stage"))
            {
           Application.LoadLevel("Stage2");
            }
          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
            {
           Application.LoadLevel("start");
            }
        }
        if(isGameWin2){
          Time.timeScale = 0;
        GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Next Boss!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"Boss Stage"))
            {
           Application.LoadLevel("Boss2");
            }
          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
            {
           Application.LoadLevel("start");
            }
        }
        if(isGameBoss2){
          Time.timeScale = 0;
        GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Game Win!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"Next Stage"))
            {
           Application.LoadLevel("Stage3");
            }
          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
            {
           Application.LoadLevel("start");
            }
        }
        if(isGameWin3){
          Time.timeScale = 0;
        GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Next Boss!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"Boss Stage"))
            {
           Application.LoadLevel("Boss3");
            }
          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
            {
           Application.LoadLevel("start");
            }
        }
        if(isGameBoss3){
          Time.timeScale = 0;
        GUI.Box(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Winner!!!");

          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+20,Screen.width/2-20,Screen.height/10),"ReStage"))
            {
           Application.LoadLevel("Stage1");
            }
          if(GUI.Button(new Rect(Screen.width/4+10,Screen.height/4 +Screen.height/10+90,Screen.width/2-20,Screen.height/10),"Main Menu"))
            {
           Application.LoadLevel("start");
            }
        }
        
    }
}
