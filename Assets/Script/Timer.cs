using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeTexts;
    public float totalTime;
    int retime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        retime = (int)totalTime;
        timeTexts.text = "Time Limit:" + retime.ToString();
        if (retime <= 0)
        {
            //SceneManager.LoadScene("Result");
        }
    }
}
