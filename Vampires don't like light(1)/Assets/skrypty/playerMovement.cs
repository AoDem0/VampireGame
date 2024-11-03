
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private float moveX;
    private Vector2 vec;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0){
            moveX = Input.GetAxis("Horizontal");
            animator.SetBool("isMoving", true);
            vec = new Vector2(moveX, 0);
            var movement = vec.normalized * speed;
            rb.velocity = movement;
        
        }
        else{
            animator.SetBool("isMoving", false);
        }

    }
}
