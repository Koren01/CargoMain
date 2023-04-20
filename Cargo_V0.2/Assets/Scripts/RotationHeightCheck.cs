using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHeightCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ConveyorBelt.rotateOK = true;
    }

    private void OnTriggerExit (Collider other)
    {
        ConveyorBelt.rotateOK = false;

    }
}
