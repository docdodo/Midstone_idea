using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMoveTo : MonoBehaviour
{
    

        public Transform goal;

        void Start()
        {
        goal = GameObject.Find("Player").transform;
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;
        }
    
}
