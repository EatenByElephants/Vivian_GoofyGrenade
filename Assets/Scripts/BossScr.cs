using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScr : MonoBehaviour
{

    //  public Transform goal;
    public Transform player;
    public Transform boss;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.CompareTag("Ground"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(10*(player.position.x - boss.position.x), 200, 10*(player.position.z - boss.position.z)));
        }
    }

}

