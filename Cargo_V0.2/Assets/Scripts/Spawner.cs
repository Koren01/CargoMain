using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject FretToSpawn;
    [SerializeField] private GameObject Transform;
    public bool spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnObject()
    {
        GameObject newObject = Instantiate(FretToSpawn, Transform.transform.position, Quaternion.identity);
    }
}
