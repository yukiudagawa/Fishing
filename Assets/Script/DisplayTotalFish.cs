using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTotalFish : MonoBehaviour
{
    public Text totalTexts;
    private int totalCount;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreViewmodel.totalFish >= 0)
        {
            totalCount = 3 - ScoreViewmodel.totalFish;
            totalTexts.text = "Total Fish:" + totalCount.ToString();
        }
    }
}

/*
 * max = 3
 * ScoreViewmodeltotalfish = 1
 * 
 * max - Scoreviewmodeltotalfish = 2
 */