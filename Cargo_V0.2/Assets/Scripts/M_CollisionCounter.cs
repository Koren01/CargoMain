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
    public GameObject CanvasLock;
    public GameObject CanvasUnlock;
    private bool increment = true;
    private Material baseMat;

    void Start()
    {
        CanvasLock.SetActive(false);
        baseMat = Fret.GetComponent<MeshRenderer>().material;
    }
    
    void FixedUpdate()
    {
        totalCurrentColliders = totalCollidersHit - totalCollidersLeft;

        
        if (totalCurrentColliders == 4 && increment == true)
        {
            Fret.GetComponent<MeshRenderer>().material = FretSemiLockedMat;
            CanvasLock.SetActive(true);
            increment = false;
            return;
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

        Debug.Log("Fret counter +1");
        M_FretCheck.Counter++;
        CanvasLocked();



    }
    public void Unlock()
    {
        Fret.GetComponent<MeshRenderer>().material = baseMat;
        Fret.GetComponent<Rigidbody>().isKinematic = false;

        Debug.Log("Fret counter -1");
        M_FretCheck.Counter=-2;
        CanvasUnlocked();


    }
    public void UndoCheck()
    {
        Fret.GetComponent<MeshRenderer>().material = baseMat;
        CanvasOff();
        increment = true;
        return;
    }


    
}
