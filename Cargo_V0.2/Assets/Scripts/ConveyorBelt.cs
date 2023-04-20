using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] public Vector3 direction;
    [SerializeField] public Vector3 rotationRight;
    [SerializeField] public Vector3 rotationLeft;
    [SerializeField] private List<GameObject> onBelt;
    [SerializeField] private bool move = false;
    [SerializeField] private int goBack = 1;
    private bool rotateRight;
    private bool rotateLeft;

    public static bool rotateOK = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
            for (int i = 0; i <= onBelt.Count - 1; i++)
            {
                if (move == true)
                {
                    onBelt[i].GetComponent<Rigidbody>().velocity = goBack * speed * direction * Time.deltaTime;

                }
                if(rotateOK == true)
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
    }
    
    

    public void StartBelt()
    {
        goBack = 1;
        move = true;
        Debug.Log("Avance");
        return;
    }

    public void StopBelt()
    {
        move = false;
        Debug.Log("Stop");

        return;
    }

    public void BackBelt()
    {
        goBack = -1;
        move = true;
        Debug.Log("Recule");

    }

    public void OnCollisionEnter(Collision collision)
    {
        onBelt.Add(collision.gameObject);
        Debug.Log("touche");
    }

    public void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
        Debug.Log("touche plus");


    }
}
