using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    NavMeshAgent nm;
    [SerializeField] private Transform target;

    // start er det som skjer før første frame
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        
    }

    // update er da ting som endres får hver frame
    void Update()
    {
        //så her for eksempel så vill AI'en oppdatere hvor den må gå for hver frame med tanke på hvor du er
        nm.SetDestination(target.position);
    }
}