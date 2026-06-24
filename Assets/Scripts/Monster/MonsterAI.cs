using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public Transform player;

    public float visionDistance = 10f;

    private NavMeshAgent agent;

    private bool chasing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance =
            Vector3.Distance(transform.position, player.position);

        if (distance <= visionDistance)
        {
            chasing = true;
        }

        if (chasing)
        {
            agent.SetDestination(player.position);
        }
    }
}