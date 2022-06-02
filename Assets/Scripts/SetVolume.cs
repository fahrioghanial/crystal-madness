using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    [SerializeField] private Slider slider;
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        float val;
        bool res = mixer.GetFloat("Volume", out val);
        if (res)
        {
            slider.SetValueWithoutNotify(Mathf.Pow(10, val / 20));
        }
    }

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
        if (audioSource != null && !audioSource.isPlaying)
            audioSource.Play();
    }
}
