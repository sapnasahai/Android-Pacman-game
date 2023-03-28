using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   public void Exitgame()
   {

        //UnityEditor.EditorApplication.isPlaying = false;
        print("quit");
        Application.Quit();
   }

    



}
