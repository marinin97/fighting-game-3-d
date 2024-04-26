using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform TargetPoint;

    private void Start()
    {
       

       // agent.SetDestination(TargetPoint.position);
    }

    private void Update()
    {
        agent.SetDestination(TargetPoint.position);
    }
}
