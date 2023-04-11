using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu;
    public InputActionProperty showButton;


    public AudioSource VictoryMusic;
    public AudioSource BGM;
    void Start()
    {
        menu.SetActive(false);
    }

    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;// menu spawns in front of player

        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z)); // menu has the right orientation
    }

    public void MuteMusic()
    {
        VictoryMusic.Pause();
        BGM.Pause();
    }
    public void UnMuteMusic()
    {
        VictoryMusic.UnPause();
        BGM.UnPause();
    }
}
