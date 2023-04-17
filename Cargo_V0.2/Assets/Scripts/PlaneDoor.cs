using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDoor : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    public void DoorUp()
    {
        animator.SetTrigger("planeDoorUp");
    }
    public void DoorDown()
    {
        animator.SetTrigger("planeDoorDown");
    }
}
