using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gForceScr : MonoBehaviour {

    public GameObject boss;
    // Use this for initialization
    void Start () {
        boss = GameObject.Find("BossParent");
        if (Vector3.Distance(boss.transform.position, transform.position) <= 10)
        {
           
            Vector3 dir = boss.transform.position - transform.position;
            boss.GetComponent<Rigidbody>().AddForce(dir.normalized*600);
        }
        
    }

    // Update is called once per frame

        
      
}
