using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] private AudioSource BGMAudioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void ChangeBGM(AudioClip bgmStageClip)
    {
        BGMAudioSource.Stop();
        BGMAudioSource.clip = bgmStageClip;
        BGMAudioSource.Play();
    }
    
    public void StopBGM()
    {
        BGMAudioSource.Stop();
    }
}
