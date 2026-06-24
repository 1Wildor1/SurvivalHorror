using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class MonsterPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;

    private NavMeshAgent agent;
    private int currentPoint = 0;

    private bool waiting = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (patrolPoints.Length > 0)
            agent.SetDestination(patrolPoints[0].position);
    }

    void Update()
    {
        if (waiting || patrolPoints.Length == 0)
            return;

        if (!agent.pathPending &&
            agent.remainingDistance < 0.5f)
        {
            StartCoroutine(WaitAndMove());
        }
    }

    IEnumerator WaitAndMove()
    {
        waiting = true;

        yield return new WaitForSeconds(3f);

        currentPoint++;

        if (currentPoint >= patrolPoints.Length)
            currentPoint = 0;

        agent.SetDestination(
            patrolPoints[currentPoint].position);

        waiting = false;
    }
}