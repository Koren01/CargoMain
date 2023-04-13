using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject FretToSpawn;
    [SerializeField] private GameObject Transform;

    public bool spawn = false;
    public bool Enabled = false;
    public GameObject Controller;

    void Start()
    {
    }


    void Update()
    {
        Enabled = Controller.GetComponent<TabletTime>().mybool;

    }

    public void SpawnObject()
    {
        if (Enabled == true)
        {
            GameObject newObject = Instantiate(FretToSpawn, Transform.transform.position, Quaternion.Euler(0, 270, 0));

        }
    }
}
