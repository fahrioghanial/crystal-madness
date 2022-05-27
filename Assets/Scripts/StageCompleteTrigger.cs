using UnityEngine;
using UnityEngine.SceneManagement;

public class StageCompleteTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        if (ScoringSystem.isAllCrystalCollected)
        {
            FindObjectOfType<GameManager>().SetStageCompleted();
        }
    }
}
