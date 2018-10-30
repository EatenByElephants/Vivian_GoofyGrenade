using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScr : MonoBehaviour
{
    public GameObject confetti;
    public GameObject playerObj;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (!col.CompareTag("Hand"))
       {
            Explode();
       }
    }

    public void Explode()
    {
        var cinst = Instantiate(confetti, transform.position, Quaternion.identity);
        playerObj.GetComponent<PlayerScr>().g = false;
        Destroy(gameObject);
    }
}
