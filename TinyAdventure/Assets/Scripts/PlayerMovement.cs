using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public floats
    public float moveSpeed;

    //components
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    //private variables
    private Vector2 moveDirection;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProccesInputs();

    }

    private void FixedUpdate()
    {
        // 
        Move();
        FaceTowardsMovement();
    }

    void ProccesInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

    }

    void Move() 
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        
    }

    void FaceTowardsMovement()
    {
        if (moveDirection.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    //dash/roll
    void DashTo()
    {

    }
}
