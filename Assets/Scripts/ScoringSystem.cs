using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int collectedCrystals;
    public int totalCrystals;
    public static bool isAllCrystalCollected;

    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Crystals: " + collectedCrystals + "/" + totalCrystals;
        if (collectedCrystals == totalCrystals)
        {
            isAllCrystalCollected = true;
        }
    }

}
