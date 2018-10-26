using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScr : MonoBehaviour
{
    public int time = 2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(gameObject, time);

    }
}