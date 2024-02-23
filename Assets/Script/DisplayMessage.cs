using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour
{
    [SerializeField] private Texture image;
    private RawImage parentImage;
    float totalTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        parentImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        if (totalTime < 0)
        {
            parentImage.texture = image;
            parentImage.color = Color.white;
        }
    }
}
