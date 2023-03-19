using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_AllFretDone : MonoBehaviour
{
    List<GameObject> goList;
    public GameObject Fret1;
    public GameObject Fret2;
    public GameObject Fret3;
    public GameObject Fret4;

    public bool OK1 = false;
    public bool OK2 = false;
    public bool OK3 = false;
    public bool OK4 = false;

    void Start()
    {
        goList = new List<GameObject>();
        goList.Add(Fret1);
        goList.Add(Fret2);
        goList.Add(Fret3);
        goList.Add(Fret4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
