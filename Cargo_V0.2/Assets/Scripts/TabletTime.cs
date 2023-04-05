using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabletTime : MonoBehaviour
{
    public  TMP_Text display1;
    public  TMP_Text display1VS;
    public  TMP_Text display2;
    public  TMP_Text display3;

    public TMP_Text timerText1;
    public TMP_Text timerText2;
    public TMP_Text timerText3;

    public bool startTimer;
    public bool levelEnded;

    public int hour;
    public int minutes;
    public int seconds;
    public float startTime = 0.0f;

    public AudioClip victory;
    public AudioSource soundSource;
    public int alreadyPlayed = 0;

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

        display1.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;
        display2.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;
        display3.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;
        if (startTimer == true )
        {
            timerText1.SetText("" + Mathf.Round(Time.time - startTime) + "s");
            timerText2.SetText("" + Mathf.Round(Time.time - startTime) + "s");
            timerText3.SetText("" + Mathf.Round(Time.time - startTime) + "s");
        }

        if(startTimer == false && levelEnded == true)
        {
            display1VS.SetText("Congratulations! Your timer is: ");

            if (!soundSource.isPlaying && alreadyPlayed <= 0)
            {
                soundSource.clip = victory;
                soundSource.Play();
                alreadyPlayed++;
            }
        }
        
    }

    public void StartTimer()
    {
        startTimer = true;
        startTime = Time.time;
    }

    
}
