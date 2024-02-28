using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThrowFish : MonoBehaviour
{
    [SerializeField] InputActionReference playerAction;

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
        Debug.Log("B pressed");
        if (ScoreViewmodel.totalFish < 3)
        {
            ScoreViewmodel.totalFish += 1;
        }
    }
}