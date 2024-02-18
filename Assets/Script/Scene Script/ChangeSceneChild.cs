using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeSceneChild : MonoBehaviour
{
    [SerializeField] InputActionReference playerAction;
    [SerializeField] ChangeSceneManager.SCENE nextScene;

    private void Awake()
    {
        playerAction.action.started += Toggle;
    }

    private void OnDestroy()
    {
        playerAction.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        ChangeSceneManager.Instance.LoadScene(nextScene);
    }
}
