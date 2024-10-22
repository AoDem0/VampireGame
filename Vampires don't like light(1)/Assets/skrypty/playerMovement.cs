using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private float moveX;
    private Vector2 vec;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        
        vec = new Vector2(moveX, 0);
        var movement = vec.normalized * speed;
        rb.velocity = movement;
        
    }
}
