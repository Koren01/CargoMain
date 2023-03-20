using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class M_CollisionCounter : MonoBehaviour
{

        //PUT ON FRET

    
    public int totalCollidersHit;
    public int totalCollidersLeft;
    public int totalCurrentColliders;
    public GameObject Fret;
    public Material FretSemiLockedMat;
    public Material FretLockedMat;
    public GameObject Canvas;
    private bool increment = true;
    void Start()
    {
        Canvas.SetActive(false);
    }

    void Update()
    {
        totalCurrentColliders = totalCollidersHit - totalCollidersLeft;

        if (totalCurrentColliders == 4 && increment == true)
        { 
            CheckIncrement();
            return;
        } 
    }

    public void CheckIncrement ()
    {
        Fret.GetComponent<MeshRenderer>().material = FretSemiLockedMat;
        M_FretCheck.Counter++;
        increment = false;
        Canvas.SetActive(true);
        return;
    }


    public void LockFret()
    {
        Fret.GetComponent<Rigidbody>().isKinematic = true;
        Fret.GetComponent<MeshRenderer>().material = FretLockedMat;
        Canvas.SetActive(false);


    }
}
