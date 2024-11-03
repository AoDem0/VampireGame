using System.Collections;

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
