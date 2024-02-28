using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    [SerializeField] private Texture[] image;
    private RawImage parentImage;
    private Color temp;
    [SerializeField] CatchingFish catchingFish;
    [SerializeField] private GameObject fishGameObject;
    private CatchingFish fishScript;
    [SerializeField] private int ran;
    private int imageNum;
    private int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        parentImage = GetComponent<RawImage>();
        temp = parentImage.color;
        ScoreViewmodel.totalFish = 2;
        //GameObject obj = GameObject.Find("Fish");
        //fishScript = obj.GetComponent<CatchingFish>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CatchFishViewmodel.catchFishViewModel == 1)
        {
            parentImage.texture = image[imageNum];
            parentImage.color = Color.white;

            if (ran > 50)
            {
                ScoreViewmodel.totalFish -= 1;
            }

            if (ran > 50 && ScoreViewmodel.totalFish < 0)
            {
                scoreValue = -1;
            }

            ScoreViewmodel.totalScore += scoreValue;
            scoreValue = 0;
            ran = 0;

            Debug.Log(ScoreViewmodel.totalScore);
        }
        else
        {
            ran = Random.Range(51, 100);
            if (ran <= 10)
            {
                imageNum = 3;
                scoreValue = 5;
            }
            else if(ran <= 30)
            {
                imageNum = 2;
                scoreValue = 3;
            }
            else if (ran <= 50)
            {
                imageNum = 1;
                scoreValue = 2;
            }
            else if(ran <= 100)
            {
                imageNum = 0;
                scoreValue = 1;
/*                if (ScoreViewmodel.totalFish > 0)
                {
                    Debug.Log(ScoreViewmodel.totalFish);
                    Debug.Log(scoreValue);
                    ScoreViewmodel.totalFish -= 1;
                }
                else 
                {
                    Debug.Log("Less Fish: " + scoreValue);
                    scoreValue = -1;
                }*/
            }
            parentImage.color = temp;
        }
    }
}
