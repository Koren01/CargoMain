using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject FretToSpawn;
    [SerializeField] private GameObject Transform;

    public bool spawn = false;
    public bool Enabled = false;
    public GameObject Getter;

    void Start()
    {
    }


    void Update()
    {
        Enabled = Getter.GetComponent<TabletTime>().mybool2;

    }

    public void SpawnObject()
    {
        if (Enabled == true)
        {
            GameObject newObject = Instantiate(FretToSpawn, Transform.transform.position, Quaternion.Euler(0, 270, 0));

        }
    }
}
