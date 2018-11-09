using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathsScr : MonoBehaviour
{
    public GameObject WinC;
    public GameObject DeathC;
    public GameObject boss;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        boss = GameObject.Find("BossParent");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.transform.position.y < 0)
        {
            Win();
        }
        if (player.transform.position.y < 0)
        {
            Death();
        }

    }
   public void Death()
    {
        Debug.Log("Ya Deathed");
        DeathC.SetActive(true);
        player.GetComponent<PlayerScr>().CanShoot = false;
    }
    void Win()
    {
        Debug.Log("Boss Killed");
        WinC.SetActive(true);
    }
}
