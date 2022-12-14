using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
         enemy = GetComponent<NavMeshAgent>();
         enemy.speed = 11;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
