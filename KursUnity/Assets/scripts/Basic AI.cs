using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{

    [SerializeField] private NavMeshAgent m_NavMeshAgent;
    [SerializeField] private GameObject m_target;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_NavMeshAgent.SetDestination(m_target.transform.position);
    }
}
