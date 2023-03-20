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
    private Material baseMat;
    void Start()
    {
        Canvas.SetActive(false);
        baseMat = Fret.GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        totalCurrentColliders = totalCollidersHit - totalCollidersLeft;

        if (totalCurrentColliders == 4 && increment == true)
        {
            Fret.GetComponent<MeshRenderer>().material = FretSemiLockedMat;
            CheckIncrement();

            return;
        }
    }

    public void CheckIncrement()
    {
        Canvas.SetActive(true);
        increment = false;
        return;
    }


    public void LockFret()
    {
        Fret.GetComponent<Rigidbody>().isKinematic = true;
        Fret.GetComponent<MeshRenderer>().material = FretLockedMat;
        M_FretCheck.Counter++;
        Canvas.SetActive(false);
        increment = false;
        return;



    }

    public void UndoCheck()
    {
        Fret.GetComponent<MeshRenderer>().material = baseMat;
        Canvas.SetActive(false);
        increment = true;
        return;
    }
}
