using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EagleMove : MonoBehaviour
{
    private Rigidbody rb;
    private Transform objectTransform;
    private Vector3 startPosition;
    [SerializeField] private float Speed;
    [SerializeField] private float Distance;
    [SerializeField] private bool MoveRight;
    private int directionConstant = 1;
    private float distanceTravel;
    private float angle;
    private float Atest;
    private float Btest;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        objectTransform = GetComponent<Transform>();

        /*   float a = 90;
           if (objectTransform.eulerAngles.y < 0)
           {
               a *= -1;
           }
           angle = objectTransform.eulerAngles.y;
           while (objectTransform.eulerAngles.y < 0 || objectTransform.eulerAngles.y > 90)
           {
               angle -= a;
           }*/
        //TODO MAKE A SYSTEM TO
        Atest = Mathf.Sin(objectTransform.eulerAngles.y * Mathf.Deg2Rad);   //sin works for x
        Btest = Mathf.Cos(objectTransform.eulerAngles.y * Mathf.Deg2Rad);   //cos works for z

        if (!MoveRight) 
        { 
            directionConstant = -1;
        }


        
        //objectTransform.Rotate(0, directionConstant * 90.0f, 0);
        startPosition = objectTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(0, 0, Speed * Btest);
        //rb.velocity = new Vector3(Speed * Atest, 0, 0);
        rb.velocity = new Vector3(Speed * Atest, 0, Speed * Btest);
        distanceTravel = directionConstant * (objectTransform.position.x - startPosition.x);
        if (distanceTravel > Distance)
        {
            objectTransform.position = startPosition;
        }
    }
}
