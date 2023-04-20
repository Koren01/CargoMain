using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public GameObject Transform1;
    public GameObject Transform2;
    public GameObject Transform3;
    public GameObject Transform4;
    List<GameObject> GOList;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        GOList = new List<GameObject>();
        GOList.Add(Transform1);
        GOList.Add(Transform2);
        GOList.Add(Transform3);
        GOList.Add(Transform4);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fret") {
            if(i < 4)
            {
                other.gameObject.transform.position = GOList[i].transform.position;
                i++;
                M_FretCheck.Counter2++;
                M_FretCheck.Unload--;
            }
            
        }
    }


    private void OldMethodObsolete(Collider other)
    {
        if (other.tag == "Fret")
        {
            Debug.Log("contact");
            //Destroy(other.gameObject);
            //teleport because destroy will break the conveyor belt for some reason
            other.gameObject.transform.position = Transform1.transform.position;
            M_FretCheck.Counter2++;
            M_FretCheck.Unload--;
        }
    }
}
