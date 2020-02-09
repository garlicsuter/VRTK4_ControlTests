using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicDrop : MonoBehaviour
{
    public GameObject MicSpawnLocation;
    public GameObject Mic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MicDropper()
    {
        Debug.Log("Drop Mic When Ready.");
        Instantiate(Mic, MicSpawnLocation.transform.position, MicSpawnLocation.transform.rotation);
    }
}
