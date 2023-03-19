using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class M_CollisionCounter : MonoBehaviour
{

        //PLACE ON FRET

    
    public int totalCollidersHit;
    public int totalCollidersLeft;
    public int totalCurrentColliders;
    public GameObject Fret;
    public Material FretLockedMat;
    private M_FretCheck boolToAccess;
    // Start is called before the first frame update
    void Start()
    {
        boolToAccess = Fret.GetComponent<M_FretCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        totalCurrentColliders = totalCollidersHit - totalCollidersLeft;

        if (totalCurrentColliders == 4)
        {
            
            Fret.GetComponent<MeshRenderer>().material = FretLockedMat;
            Fret.GetComponent<Rigidbody>().isKinematic = true;

            boolToAccess.setFret = true;
            //Fret.GetComponent<Transform>().position = Spawner.position;
            
            return;
        }


        return;
    }
}
