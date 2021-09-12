using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageselect : MonoBehaviour
{
    void OnGUI(){

       GUI.backgroundColor = Color.black;
       if(GUI.Button(new Rect(Screen.width/2-135,(Screen.height/2)-50,300,70),"Stage1 (Easy)"))
       {
           Application.LoadLevel("Stage1");
       }
       if(GUI.Button(new Rect(Screen.width/2-135,(Screen.height/2)+40,300,70),"Stage2 (Normal)")){
           Application.LoadLevel("Stage2");
       }
       if(GUI.Button(new Rect(Screen.width/2-135,(Screen.height/2)+130,300,70),"Stage3 (Hard)")){
           Application.LoadLevel("Stage3");
       }
   }
}
