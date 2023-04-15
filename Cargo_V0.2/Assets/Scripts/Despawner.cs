using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
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
            Destroy(other.gameObject);
            M_FretCheck.Unload--;
            M_FretCheck.Counter2++;
        }
    }
}
