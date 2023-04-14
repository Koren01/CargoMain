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
    public AudioSource VictorySoundSource;
    public AudioSource BGMSoundSource;
    public int alreadyPlayed = 0;

    public GameObject ULDLayout;

    public bool mybool = false;



    void Start()
    {
        ULDLayout.SetActive(false);
        

    }

    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;
        if (display1)
        {
            display1.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;

        }
        if (display2)
        {
            display2.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;

        }
        if (display3)
        {
            display3.GetComponent<TMP_Text>().text = hour + ":" + minutes + ":" + seconds;

        }
        if (startTimer == true )
        {
            if (timerText1)
            {
                timerText1.SetText("" + Mathf.Round(Time.time - startTime) + "s");

            }
            if (timerText2)
            {
                timerText2.SetText("" + Mathf.Round(Time.time - startTime) + "s");

            }
            if (timerText3)
            {
                timerText3.SetText("" + Mathf.Round(Time.time - startTime) + "s");

            }

            if (ULDLayout)
            {
                ULDLayout.SetActive(true);

            }
        }

        if(startTimer == false && levelEnded == true)
        {
            if (display1VS)
            {
                display1VS.SetText("Congratulations! Your timer is: ");

            }
            if(ULDLayout)
            {
                ULDLayout.SetActive(false);

            }

            if (!VictorySoundSource.isPlaying && alreadyPlayed <= 0)
            {
                BGMSoundSource.Pause();
                VictorySoundSource.clip = victory;
                VictorySoundSource.Play();
                alreadyPlayed++;
                

            }
        }
        
    }

    public void StartTimer()
    {
        startTimer = true;
        startTime = Time.time;
        mybool = true;
      
    }

    
}
