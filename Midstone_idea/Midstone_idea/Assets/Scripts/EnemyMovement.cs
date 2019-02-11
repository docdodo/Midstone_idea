using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{

    public bool playerSpotted;
    public Transform goal;
    
    Vector3 destination;
    NavMeshAgent agent;
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }
   public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("YEs");

            goal = other.gameObject.transform;
           

        }
    }
   
    public void Update()
    {
        destination = goal.position;
        agent.destination = destination;
    }
   
}
