using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFishViewmodel : MonoBehaviour
{
    public static int catchFishViewModel;

    public IEnumerator FishCatched()
    {
        catchFishViewModel = 1;
        yield return new WaitForSeconds(3);
        catchFishViewModel = 0;
    }
}
