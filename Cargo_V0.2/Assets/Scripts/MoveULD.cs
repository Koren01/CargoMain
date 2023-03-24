using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveULD : MonoBehaviour
{
    public float speed = 5;
    public Transform target;
    public bool Move;

    void Update()
    {
        if (Move)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
}
