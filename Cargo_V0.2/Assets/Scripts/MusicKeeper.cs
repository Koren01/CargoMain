using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicKeeper : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);  
    }
}
