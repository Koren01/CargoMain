using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckRotator : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] public Vector3 rotationRight;
    [SerializeField] public Vector3 rotationLeft;
    [SerializeField] private List<GameObject> onBelt;
    private bool rotateRight;
    private bool rotateLeft;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        for (int i = 0; i <= onBelt.Count - 1; i++)
        {
            
            
                if (rotateRight == true)
                {
                    onBelt[i].transform.Rotate(rotateSpeed * Time.deltaTime * rotationRight);

                }
                if (rotateLeft == true)
                {
                    onBelt[i].transform.Rotate(rotateSpeed * Time.deltaTime * rotationLeft);

                }
            




        }

    }

    public void RotateRight()
    {
        rotateRight = true;
        rotateLeft = false;
        return;
    }
    public void RotateLeft()
    {
        rotateLeft = true;
        rotateRight = false;
        return;
    }

    public void RotateNull()
    {
        rotateLeft = false;
        rotateRight = false;
        return;
    }


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fret"))
        {
            onBelt.Add(other.gameObject);
            Debug.Log("touche");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fret"))
        {
            onBelt.Remove(other.gameObject);
            Debug.Log("touche plus");
        }
        

    }
}
