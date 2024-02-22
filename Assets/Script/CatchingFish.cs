using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchingFish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            StartCoroutine(ChangePos());
            //Destroy(this.gameObject);
        }
    }

    private IEnumerator ChangePos()
    {
        gameObject.transform.Find("shadow").gameObject.SetActive(false);
        yield return new WaitForSeconds(3);
        Vector3 pos = transform.position;
        pos.x = Random.Range(-40, 40);
        pos.y = 0;
        pos.z = Random.Range(-40, 40);
        transform.position = pos;
        gameObject.transform.Find("shadow").gameObject.SetActive(true);
    }
}
