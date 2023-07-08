using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAi : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    public Transform target;

    private void Start()
    {
        target = GameObject.Find("OurTower").transform;
    }

    public void Update()
    {
        _agent.destination = target.position;
      
    }
}
