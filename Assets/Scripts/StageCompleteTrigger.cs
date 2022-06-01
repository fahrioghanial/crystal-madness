using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class StageCompleteTrigger : MonoBehaviour
{
    public GameObject warningUI;

    IEnumerator OnTriggerEnter()
    {
       

        if (ScoringSystem.isAllCrystalCollected)
        {
            FindObjectOfType<GameManager>().SetStageCompleted();
        }
        else
        {
            GetComponent<Collider>().isTrigger = false;
            warningUI.SetActive(true);
            yield return new WaitForSeconds(5);
            warningUI.SetActive(false);
            GetComponent<Collider>().isTrigger = true;
        }
    }
}

