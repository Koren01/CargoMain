using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] public Vector3 direction;
    [SerializeField] private List<GameObject> onBelt;
    [SerializeField] private bool move = false;
    [SerializeField] private int goBack = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(move == true)
        {
            for (int i = 0; i <= onBelt.Count - 1; i++)
            {
                onBelt[i].GetComponent<Rigidbody>().velocity = goBack * speed * direction * Time.deltaTime;
            }
        }
        
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
