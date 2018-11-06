using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathsScr : MonoBehaviour
{
    public GameObject boss;
    // Use this for initialization
    void Start()
    {
        boss = GameObject.Find("BossParent");
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.transform.position.y < 0)
        {
            Win();
        }

    }
   public void Death()
    {
        Debug.Log("Ya Deathed");
    }
    void Win()
    {
        Debug.Log("Boss Killed");
    }
}
