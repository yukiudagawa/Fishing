using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    private TMP_Text scoreText;
    private int scoreInt;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();

        if (ScoreViewmodel.totalScore > 0)
        {
            scoreText.SetText(ScoreViewmodel.totalScore.ToString() + " Points");
        }
    }
}
