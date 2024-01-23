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
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Rod").transform; //追いかける対象のオブジェクトのtransformを取得
        rigidbody = GetComponent<Rigidbody>(); //Rigidbodyを取得
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation; //オブジェクトの回転を防ぐ
        agent = GetComponent<NavMeshAgent>(); //NavMeshAgentを取得
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
