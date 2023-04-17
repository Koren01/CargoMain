using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public GameObject Transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fret") {
            Debug.Log("contact");
            //Destroy(other.gameObject);
            //teleport because destroy will break the conveyor belt for some reason
            other.gameObject.transform.position = Transform.transform.position;
            M_FretCheck.Counter2++;
            M_FretCheck.Unload--;
        }
    }
}
