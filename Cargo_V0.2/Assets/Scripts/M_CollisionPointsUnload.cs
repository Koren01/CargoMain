using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class M_CollisionPointsUnload : MonoBehaviour
{

    //PLACE ON PLANE/COLLIDERS

    void Start()
    {


    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fret"))
        {
            M_LockedFret count1 = other.gameObject.GetComponent<M_LockedFret>();
            count1.totalCollidersHit += 1;


            Debug.Log("1 collider hit");
            Debug.Log(count1.totalCollidersHit);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fret"))
        {
            M_LockedFret count2 = other.gameObject.GetComponent<M_LockedFret>();
            count2.totalCollidersLeft += 1;

            Debug.Log("1 collider less");
            Debug.Log(count2.totalCollidersLeft);

        }


    }
}
