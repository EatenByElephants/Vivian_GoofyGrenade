using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossScr : MonoBehaviour
{

    //  public Transform goal;
    public Transform player;

    // Use this for initialization
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        NavMeshHit hit;

        Debug.Log(player.position);
        Debug.Log(agent.destination);
        if (NavMesh.SamplePosition(player.position, out hit, 10f, NavMesh.AllAreas))
        {
            agent.destination = hit.position;
        }

    }
}
	
