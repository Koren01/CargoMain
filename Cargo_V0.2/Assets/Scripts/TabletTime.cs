using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabletTime : MonoBehaviour
{
    public  TMP_Text theDisplay;
    public TMP_Text timerText;
    public bool startTimer;
    public int hour;
    public int minutes;
    public int seconds;
    public float startTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;

        theDisplay.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;
        if (startTimer == true)
        {
            timerText.SetText("" + Mathf.Round(Time.time - startTime) + "s");
        }
        
    }

    public void StartTimer()
    {
        startTimer = true;
        startTime = Time.time;
    }
}
