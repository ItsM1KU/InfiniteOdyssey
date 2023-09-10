using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MainMenuMusic : MonoBehaviour
{
    [SerializeField] private AudioMixer MainMenuMixer;
    //[SerializeField] AudioSource sfx;

    private void Update()
    {
        DontDestroyOnLoad(this);
    }
    public void setVolume (float SliderVolume)
    {
        MainMenuMixer.SetFloat("MainMenuVolume", Mathf.Log10(SliderVolume) * 20);
    }




}
