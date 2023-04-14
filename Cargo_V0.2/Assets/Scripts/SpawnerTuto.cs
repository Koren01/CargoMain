using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTuto : MonoBehaviour
{
    [SerializeField] private GameObject FretToSpawn;
    [SerializeField] private GameObject Transform;

    public bool spawn = false;
    public bool Enabled = true;

    void Start()
    {
    }


    void Update()
    {

    }

    public void SpawnObject()
    {
        if (Enabled == true)
        {
            GameObject newObject = Instantiate(FretToSpawn, Transform.transform.position, Quaternion.Euler(0, 270, 0));

        }
    }
}