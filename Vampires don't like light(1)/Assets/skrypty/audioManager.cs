using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioSource SFXSource;
    public AudioClip burn;
    public AudioClip backMusic;

    private void Awake(){
        DontDestroyOnLoad(gameObject);
    }
    private void Start(){
        musicSource.clip = backMusic;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }

}
