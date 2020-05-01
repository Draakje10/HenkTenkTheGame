using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* Controls the Enemy AI */

public class SpiderAI : MonoBehaviour
{
    [Header("Parameters")]
    public float lookRadius = 20f;  // Detection range for player

    [Header("References")]
    
    public Transform target;   // Reference to the player
    
    NavMeshAgent agent; // Reference to the NavMeshAgent

    // Use this for initialization
    void Start()
    {
        //target = PlayerManager.instance.player.transform; //doesnt work right now
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Distance to the target
        float distance = Vector3.Distance(target.position, transform.position);

        // If inside the lookRadius
        if (distance <= lookRadius)
        {
            // Move towards the target
            agent.SetDestination(target.position);
            Debug.Log("Spider spotted player");
        }
    }



    // Show the lookRadius in editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}