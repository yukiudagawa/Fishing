using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EagleMove : MonoBehaviour
{
    private Rigidbody rb;
    private Transform eagleTransform;
    private Vector3 startPosition;
    [SerializeField] private float Speed;
    [SerializeField] private float Distance;
    [SerializeField] private bool MoveRight;
    private int directionConstant = 1;
    private float distanceTravel;

    // Start is called before the first frame update
    void Start()
    {

        if (!MoveRight) 
        { 
            directionConstant = -1;
        }

        rb = GetComponent<Rigidbody>();
        eagleTransform = GetComponent<Transform>();
        
        eagleTransform.Rotate(0, directionConstant * 90.0f, 0);
        startPosition = eagleTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = directionConstant * new Vector3(Speed, 0);
        distanceTravel = directionConstant * (eagleTransform.position.x - startPosition.x);
        if (distanceTravel > Distance)
        {
            eagleTransform.position = startPosition;
        }
    }
}
