using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Running : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    private void Awake()
    {
        player = GameObject.Find("PlayerObj").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
        transform.LookAt(player);
    }

    void Start()
    {
        Awake();
        ChasePlayer();
    }

    void Update()
    {

    }
}
