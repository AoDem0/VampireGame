using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{    

    private void Start()
    {
        StartCoroutine(ChangeSceneAfterDelay(5f));
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("credits");
    }
    
}
