using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSign : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform sinker = this.transform;
        
        Vector3 sinkerPos = sinker.position;
        Vector3 target = GameObject.Find("Plane").transform.position;
        //GameObject.Find("Plane").transform.position = new Vector3(target.x, target.y, target.z);

        if (sinkerPos.y <= target.y)
        {
            Invoke(nameof(FishSign), Random.Range(1.0f, 8.0f));
            Debug.Log("Start");
            
        }
    }

    void FishSign()
    {
        Debug.Log("Fishing");
        CancelInvoke();
    }
}
