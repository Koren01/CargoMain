using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class M_FretCheck : MonoBehaviour
{
    // on controller

    public static float Counter;
    public static float Remaining;

    public float UldsToLoad = 1;

    public TMP_Text UldsLeftMonitor;
    public TMP_Text UldsLeftWatch;
    public TabletTime controller;
    private void Start()
    {
        {
            Remaining = UldsToLoad;

        }
    }

    void Update()
    {
        if (UldsLeftMonitor)
        {
            UldsLeftMonitor.SetText("Remaining ULDs: " + Remaining);

        }
        if (UldsLeftWatch)
        {
            UldsLeftWatch.SetText("Remaining ULDs: " + Remaining);

        }

        if (Counter == UldsToLoad)
        {
            Debug.Log("BRAVO");
            controller.startTimer = false;
            controller.levelEnded = true;

            

            return;

            // Si on a les 4 validés, fais quelque chose
        }
        
    }
}
