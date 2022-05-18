using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int collectedCrystals;
    public int totalCrystals;

    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Crystals: " + collectedCrystals + "/" + totalCrystals;
    }
}
