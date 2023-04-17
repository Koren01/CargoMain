using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class M_LockedFret : MonoBehaviour
{

    //PUT ON FRET


    public int totalCollidersHit;
    public int totalCollidersLeft;
    public int totalCurrentColliders;
    public GameObject Fret;
    public GameObject FretForMat;
    public Material FretSemiLockedMat;
    public Material FretLockedMat;
    public GameObject CanvasLock;
    public GameObject CanvasUnlock;
    private bool increment = true;
    private Material baseMat;

    void Start()
    {
        LockFret();
        baseMat = FretForMat.GetComponent<MeshRenderer>().material;

    }

    void FixedUpdate()
    {
        totalCurrentColliders = totalCollidersHit - totalCollidersLeft;


        if (totalCurrentColliders == 4 && increment == true)
        {
            Fret.GetComponent<MeshRenderer>().material = FretSemiLockedMat;
            CanvasLock.SetActive(true);


        }
        else if (totalCurrentColliders != 4 && increment == true)
        {
            Fret.GetComponent<MeshRenderer>().material = baseMat;
            CanvasOff();
        }
    }

    public void CanvasLocked()
    {

        CanvasLock.SetActive(false);
        CanvasUnlock.SetActive(true);

    }
    public void CanvasUnlocked()
    {

        CanvasUnlock.SetActive(false);
        CanvasLock.SetActive(true);

    }

    public void CanvasOff()
    {
        CanvasLock.SetActive(false);
        CanvasUnlock.SetActive(false);
    }

    public void LockFret()
    {

        Fret.GetComponent<Rigidbody>().isKinematic = true;
        Fret.GetComponent<MeshRenderer>().material = FretLockedMat;

        M_FretCheck.Remaining--;

        increment = false;
        CanvasLocked();



    }
    public void Unlock()
    {
        Fret.GetComponent<MeshRenderer>().material = baseMat;
        Fret.GetComponent<Rigidbody>().isKinematic = false;

        M_FretCheck.Remaining++;
        increment = true;
        CanvasUnlocked();


    }
    public void UndoCheck()
    {



    }



}
