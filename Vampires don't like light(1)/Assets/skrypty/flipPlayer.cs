using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class flipPlayer : MonoBehaviour
{   
    private float input;
    public SpriteRenderer sp;

    void Update()
    {
        input = Input.GetAxis("Horizontal");
        Flip();
    }
    private void Flip(){
        if(input < 0){
            sp.flipX = false;
        }
        else if(input > 0){
            sp.flipX = true;
        }
    }
}
