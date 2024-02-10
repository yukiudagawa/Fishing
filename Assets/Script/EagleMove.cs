using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EagleMove : MonoBehaviour
{
    private Rigidbody rb;
    private Transform currentPoint;
    [SerializeField] private float Speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Speed, 0);
    }
}
