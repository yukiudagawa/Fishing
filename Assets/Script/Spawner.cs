using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] listOfObjects;
    [SerializeField] private int totalObjects;
    [SerializeField] private int height;
    private Collider areaCollider;
    private GameObject[] spawnedObjects;

    // Start is called before the first frame update
    void Start()
    {
        areaCollider = GetComponent<Collider>();
        spawnedObjects = new GameObject[totalObjects];

        for (int i = 0; i < totalObjects; i++)
        {
            Vector3 randomStartPosition = new Vector3(Random.Range(areaCollider.bounds.min.x, areaCollider.bounds.max.x), height, Random.Range(areaCollider.bounds.min.z, areaCollider.bounds.max.z));
            spawnedObjects[i] = Instantiate(listOfObjects[Random.Range(0, listOfObjects.Length)], randomStartPosition, Quaternion.Euler(new Vector3(0, 90, 0)));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetPositionAndRotation(new Vector3(areaCollider.bounds.min.x, height, Random.Range(areaCollider.bounds.min.z, areaCollider.bounds.max.z)), Quaternion.Euler(new Vector3(0, 90, 0)));
    }
}
