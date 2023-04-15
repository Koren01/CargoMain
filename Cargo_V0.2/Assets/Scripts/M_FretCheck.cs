using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class M_FretCheck : MonoBehaviour
{
    // on controller

    public static float Counter;
    public static float Remaining;
    public static float Unload;
    public static float Counter2;

    public float UldsToLoad = 4;
    public float UldsToUnload = 4;

    public TMP_Text UldsLeftMonitor;
    public TMP_Text UldsLeftWatch;
    public TabletTime controller;
    // tick reverse in editor for the unloading level
    public bool reverse;
    private void Start()
    {
        {
            Remaining = UldsToLoad;
            Unload = UldsToUnload;

        }
    }

    void Update()
    {
        if (reverse== true)
        {
            if (UldsLeftMonitor)
            {
                UldsLeftMonitor.SetText("Remaining ULDs: " + Unload);
            }
            if (UldsLeftWatch)
            {
                UldsLeftWatch.SetText("Remaining ULDs: " + Unload);
            }

        if (Counter2== UldsToUnload)
            {
                Debug.Log("BRAVO");
                controller.startTimer = false;
                controller.levelEnded = true;
            }
        }
        else
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
}
