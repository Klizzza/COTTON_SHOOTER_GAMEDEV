using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    // Variables
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private GameObject Objetivo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Find();
        enemy.SetDestination(Objetivo.transform.position);
    }
    void Find()
    {
        Objetivo = GameObject.Find("Capsule");
    }
}
