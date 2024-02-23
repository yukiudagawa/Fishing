using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    [SerializeField] private Texture image;
    private RawImage parentImage;
    private Color temp;
    public CatchingFish catchingFish;
    [SerializeField] private GameObject fishGameObject;
    private CatchingFish fishScript;
    // Start is called before the first frame update
    void Start()
    {
        parentImage = GetComponent<RawImage>();
        temp = parentImage.color;
        GameObject obj = GameObject.Find("Fish");
        fishScript = obj.GetComponent<CatchingFish>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fishScript.catchfish == 1)
        {
            parentImage.texture = image;
            parentImage.color = Color.white;
        }
        else
        {
            parentImage.texture = image;
            parentImage.color = temp;
        }
    }
}
