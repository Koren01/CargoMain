using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class  M_CollisionPoints : MonoBehaviour
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
            M_CollisionCounter count1 = other.gameObject.GetComponent<M_CollisionCounter>();
            count1.totalCollidersHit += 1;
            
            
            Debug.Log("1 collider hit");
            Debug.Log(count1.totalCollidersHit);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fret")) 
        {
            M_CollisionCounter count2 = other.gameObject.GetComponent<M_CollisionCounter>();
            count2.totalCollidersLeft += 1;

            Debug.Log("1 collider less");
            Debug.Log(count2.totalCollidersLeft);

        }
        

    }
}
