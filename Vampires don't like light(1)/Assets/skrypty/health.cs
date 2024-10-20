using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int zdrowie = 3;
    public Image[] pasekSerc;



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
        Debug.Log("Wejscie playera w swiatlo");
        zdrowie--;

        if(zdrowie == 0){
            Debug.Log("SMIERC");
        }
    }
}
