using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public float followSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(player.position.x, player.position.y + 3 , -10f);
        transform.position = Vector3.Slerp(transform.position, offset, followSpeed);
    }
}
    