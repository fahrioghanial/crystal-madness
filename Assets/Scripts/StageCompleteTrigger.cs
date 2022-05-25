using UnityEngine;
using UnityEngine.SceneManagement;

public class StageCompleteTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        if (ScoringSystem.isAllCrystalCollected)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
