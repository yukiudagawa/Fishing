using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EagleMove : MonoBehaviour
{
    private Rigidbody rb;
    private Transform objectTransform;
    [SerializeField] private float Distance;
    [SerializeField] private float Speed;
    private float axis_x;
    private float axis_z;
    private Vector3 startPosition;
    private float distanceTravelled;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        objectTransform = GetComponent<Transform>();

        axis_x = Mathf.Sin(objectTransform.eulerAngles.y * Mathf.Deg2Rad);   //sine for x
        axis_z = Mathf.Cos(objectTransform.eulerAngles.y * Mathf.Deg2Rad);   //cosine for z

        startPosition = objectTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Speed * axis_x, 0, Speed * axis_z);

        distanceTravelled = Mathf.Sqrt(Mathf.Pow(objectTransform.position.x - startPosition.x, 2) + Mathf.Pow(objectTransform.position.z - startPosition.z, 2));
        
        if (distanceTravelled > Distance)
        {
            objectTransform.position = startPosition;
        }
    }
}
