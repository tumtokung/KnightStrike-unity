using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public int healthBar = 100,stamina = 100;
    void OnGUI()
    {
   
      GUI.backgroundColor = Color.red;
      GUI.Button(new Rect(Screen.width-(Screen.width-100),10,(healthBar*2),20),"");
      GUI.backgroundColor = Color.yellow;
      GUI.Button(new Rect(Screen.width-(Screen.width-100),30,(stamina*2),20),"");
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
