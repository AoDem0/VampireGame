using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public float followSpeed = 2f;


    void FixedUpdate()
    { 
        if(player.transform.position.x > -16.87 & player.transform.position.x < 123.0709){
            offset = new Vector3(player.position.x, player.position.y + 2.6f , -10f);
            transform.position = Vector3.Slerp(transform.position, offset, followSpeed);
        }
    }
}
    