using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public List<GameObject> onBelt;
    public bool move = false;
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
                onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
            }
        }
        
    }

    public void StartBelt()
    {
        move = true;
        Debug.Log("bouge");
        return;
    }

    public void StopBelt()
    {
        move = false;
        Debug.Log("bouge pas");

        return;
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
