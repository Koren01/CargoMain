using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_FretCheck : MonoBehaviour
{
   
    public static float Counter;
    //public bool setFret = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Counter == 4)
        {
            Debug.Log("bravo");
            return;

            // Si on a les 4 validés, fais quelque chose
        }
    }
}
