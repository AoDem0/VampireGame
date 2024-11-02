using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public AudioSource SFXSource;
    public AudioClip click;
    // void Start()
    // {
    //     SFXSource.PlayOneShot(burn);
    public void GameStart()
    {   
        SFXSource.PlayOneShot(click);
        SceneManager.LoadScene("dialog");
       
    }
        public void Again()
    {   
        SFXSource.PlayOneShot(click);
        SceneManager.LoadScene("poziom1");
    }
    public void QuitGame()
    {
        SFXSource.PlayOneShot(click);
        Debug.Log("Quit");
        Application.Quit();
    }
}
