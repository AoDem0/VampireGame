
using UnityEngine;

public class lightMovement : MonoBehaviour
{
    public Transform[] points;
    public float moveSpeed;
    private int pointIndex;
    
    void Start()
    {
        transform.position = points[pointIndex].transform.position;
    }

    void FixedUpdate()
    {
        if(pointIndex <= points.Length -1){
            transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].transform.position, moveSpeed * Time.deltaTime);
        
            if(transform.position == points[pointIndex].transform.position){
                pointIndex += 1;
            }

            if(pointIndex == points.Length){
                pointIndex = 0;
            }
        }
    }
}
