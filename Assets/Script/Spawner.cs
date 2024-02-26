using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] listOfObjects;
    [SerializeField] private int totalObjects;
    [SerializeField] private int height;
    [SerializeField] private int leastX;
    [SerializeField] private int leastZ;
    private GameObject[] spawnedObjects;

    // Start is called before the first frame update
    void Start()
    {
        spawnedObjects = new GameObject[totalObjects];

        for (int i = 0; i < totalObjects; i++)
        {
            Vector3 randomStartPosition = new Vector3(Random.Range(leastX, leastX + 688), height, Random.Range(leastZ, leastZ + 648));
            spawnedObjects[i] = Instantiate(listOfObjects[Random.Range(0, listOfObjects.Length)], randomStartPosition, Quaternion.Euler(new Vector3(0, 90, 0)));
        }
    }

 /*   private void OnTriggerExit(Collider other)
    {
        other.transform.SetPositionAndRotation(new Vector3(leastX, height, Random.Range(leastZ, leastZ + 648)), Quaternion.Euler(new Vector3(0, 90, 0)));
    }*/
}
