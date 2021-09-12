using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageStart : MonoBehaviour
{

  void OnGUI(){

       GUI.backgroundColor = Color.black;
       if(GUI.Button(new Rect(Screen.width/2-135,(Screen.height/2)-20,250,60),"StartGame"))
       {
           Application.LoadLevel("SelectStage");
       }
        if(GUI.Button(new Rect(Screen.width/2-135,(Screen.height/2)+60,250,60),"Tutorial"))
       {
           Application.LoadLevel("Tutorial");
       }
       if(GUI.Button(new Rect(Screen.width/2-135,(Screen.height/2)+140,250,60),"Quit")){
           Application.Quit(); 
       }
   }
}
