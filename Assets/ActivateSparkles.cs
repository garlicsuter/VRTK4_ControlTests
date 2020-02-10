using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSparkles : MonoBehaviour
{
    public GameObject Fireworks;
    public ParticleSystem ps;
    

    private void Start()
    {
        Fireworks = GameObject.Find("Rocket");
        ps = Fireworks.GetComponent<ParticleSystem>();
        ps.Stop();
    }

    public void Sparkles()
    {
        Debug.Log("It was snapped");
        ps.Play();
    }

    public void NoSparkles()
    {
        Debug.Log("It left.");
        ps.Stop();
    }

    
}
