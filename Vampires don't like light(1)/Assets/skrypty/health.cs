using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class health : MonoBehaviour
{
    public int zdrowie = 3;
    public Image[] pasekSerc;

    audioManager audioManager;

    private void Awake(){
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<audioManager>();
    }

    void Update()
    {

        for (int i = 0; i < pasekSerc.Length; i++)
        {
            if(i < zdrowie ){
                pasekSerc[i].enabled = true;
            }
            else{
                pasekSerc[i].enabled = false;
            }
        }
    }
        public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3){
            SceneManager.LoadScene("credits");
        }
        else
        {
            zdrowie--;
            audioManager.PlaySFX(audioManager.burn);

            if(zdrowie == 0){
                audioManager.PlaySFX(audioManager.burn);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
