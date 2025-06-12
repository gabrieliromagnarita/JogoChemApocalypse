using UnityEngine;
using UnityEngine.AI;

public class NaveMesh : MonoBehaviour {

    [SerializeField] private NavMeshAgent inimigo;
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        //inimigo.SetDestination(player.position);
    }
}