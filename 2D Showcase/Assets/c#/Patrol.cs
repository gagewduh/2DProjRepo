using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    //bunch of references and a public float for the detection radius
    public Transform[] patrolPoints;
    public float detectionRadius = 6f;
    public LayerMask playerLayer;

    private int currentPointIndex = 0;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        //if distance from point is greater then 0 go to point
        if (patrolPoints.Length > 0) agent.SetDestination(patrolPoints[currentPointIndex].position);
    }

    void Update()
    {
        // check for player
        Collider2D Player = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);

        if (Player != null)
        {
            // if player target them 
            agent.SetDestination(Player.transform.position);
        }
        else
        {
            //if no player follow path 
            if (!agent.pathPending && agent.remainingDistance < 0.5f && patrolPoints.Length > 0)
            {
                currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
                agent.SetDestination(patrolPoints[currentPointIndex].position);
            }
        }
    }

}
