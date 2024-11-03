
using UnityEngine;

public class sound : MonoBehaviour
{   public AudioSource SFXSource;
    public AudioClip burn;
    void Start()
    {
        SFXSource.PlayOneShot(burn);
    }

}
