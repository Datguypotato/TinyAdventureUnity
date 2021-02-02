using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public floats
    private Player player;

    //components
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    //private variables
    [SerializeField] private Vector2 moveDirection;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();

        if (player == null)
            Debug.LogError("There is no Player script attached to this GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        ProccesInputs();
        FaceTowardsMovement(); // moved this here since this has nothing to do with physics
    }

    private void FixedUpdate()
    {
        Move();

    }

    void ProccesInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

    }

    void Move() 
    {
        rb.velocity = moveDirection * player.speed;
        
    }

    void FaceTowardsMovement()
    {
        if (moveDirection.x < 0.0f)
        {
            //Debug.Log("Going left");
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (moveDirection.x > 0.0f)
        {
            //Debug.Log("Going right");
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

    }

    //dash/roll
    void DashTo()
    {

    }
}
