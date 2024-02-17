using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour
{
    public static ChangeSceneManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Start,
        GameLevel,
        Result
    }
}
