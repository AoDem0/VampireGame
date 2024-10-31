using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioSource SFXSource;
    public AudioClip burn;
    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }

}
