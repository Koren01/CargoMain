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
    public Material FretLockedMat;
    private bool increment = true;
    void Start()
    {

    }

    void Update()
    {
        totalCurrentColliders = totalCollidersHit - totalCollidersLeft;

        if (totalCurrentColliders == 4 && increment == true)
        { 
            Fret.GetComponent<MeshRenderer>().material = FretLockedMat;
            Fret.GetComponent<Rigidbody>().isKinematic = true;
            CheckIncrement();
            return;
        }


        
    }

    void CheckIncrement ()
    {
        M_FretCheck.Counter++;
        increment = false;
        return;
    }
}
