using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent navAgent;
    [SerializeField]
    GameObject target;
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();

        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        navAgent.SetDestination(target.transform.position);
        
    }

    public void Respawn()
    {
        transform.position = SpawnPoint.transform.position;
    }
}
