using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemiAI : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    public float attackRange = 2.0f;
    public int damage = 10;
    private float distanceToPlayer;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void AttackPlayer()
    {
        Debug.Log("¡Atacando al jugador!");
    }

    // Update is called once per frame
    void Update()
    {

        distanceToPlayer = Vector3.Distance(player.position, transform.position);

        if (distanceToPlayer <= attackRange)
        {
            AttackPlayer();
        }
        else
        {
            agent.SetDestination(player.position); 
        }
    }
}
