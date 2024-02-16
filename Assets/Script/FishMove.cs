using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
public class FishMove : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    public void OnDetectObject(Collider collider)
    {
        if(collider.gameObject.tag == "Rod")
        {
            agent.destination = collider.gameObject.transform.position;
        }
    }

    public void OnLoseObject(Collider collider)
    {
        if (collider.gameObject.tag == "Rod")
        {
            agent.destination = this.gameObject.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
