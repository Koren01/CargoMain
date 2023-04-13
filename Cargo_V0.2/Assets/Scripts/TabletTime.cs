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

    public bool mybool2 = false;



    void Start()
    {
        ULDLayout.SetActive(false);
        

    }

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

            ULDLayout.SetActive(true);
        }

        if(startTimer == false && levelEnded == true)
        {
            display1VS.SetText("Congratulations! Your timer is: ");
            ULDLayout.SetActive(false);

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
        mybool2 = true;
      
    }

    
}
