using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_FretCheck : MonoBehaviour
{
   
    public static float Counter;
    void Update()
    {
        if (Counter == 4)
        {
            Debug.Log("bravo");
            return;

            // Si on a les 4 valid�s, fais quelque chose
        }
    }
}
