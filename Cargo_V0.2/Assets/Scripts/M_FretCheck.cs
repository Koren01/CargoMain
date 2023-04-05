using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_FretCheck : MonoBehaviour
{
   
    public static float Counter;
    public TabletTime controller;
    
    void Update()
    {
        // ici on a = 4 car il faut double cliquer pour le verouillage d'uld, ce qui fait que la validation et le compte se font 2x
        if (Counter == 2)
        {
            Debug.Log("BRAVO");
            controller.startTimer = false;
            controller.levelEnded = true;
            

            return;

            // Si on a les 4 validés, fais quelque chose
        }
        
    }
}
