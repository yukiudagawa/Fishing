using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fishObject;
    private Collider areaToSpawn;
    [SerializeField] private float delay;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        areaToSpawn = GetComponent<Collider>();
        //fishObject = GetComponent<GameObject>();
        currentTime = delay;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Vector3 randomStartPosition = new Vector3(Random.Range(areaToSpawn.bounds.min.x, areaToSpawn.bounds.max.x), (areaToSpawn.bounds.max.y + 0.1f), Random.Range(areaToSpawn.bounds.min.z, areaToSpawn.bounds.max.z));
            Instantiate(fishObject, randomStartPosition, Quaternion.identity);
            currentTime = delay;
        }
    }
}
