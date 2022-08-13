using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentGoal : MonoBehaviour
{
    public Transform Goal;

    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        
        if (agent == null)
        {
            return;
        }

        agent.destination = Goal.position;
        
    }
}
