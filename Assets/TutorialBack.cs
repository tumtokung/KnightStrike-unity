using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBack : MonoBehaviour
{
void OnGUI()
    {
      if(GUI.Button(new Rect(Screen.width-80,10,80,20),"Back"))
       {
           Application.LoadLevel("start");
       }
    }
}
