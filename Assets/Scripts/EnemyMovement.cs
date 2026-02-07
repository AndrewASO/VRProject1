using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{   
    //Sets up the player transform var to be referenced
    public Transform player;
    private NavMeshAgent navMeshAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        //Creates navmesh agent
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        //If the player obj isn't null, then the navmesh agent will have its destination set to the players position.
        if (player != null){
            navMeshAgent.SetDestination(player.position);
        }
    }
}
