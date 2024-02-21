using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;





    [Header ("Ground Check")]
    public float groundDrag;
    public LayerMask whatIsGround;
    bool grounded;
    public float playerHeight;




    /*private void Start()
    {
        rb = gameObject.AddComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    */

    
    

     private void Update()
    {
        //MyInput();

        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

        // handle drag
        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;
    }
    
     
    

    
    void FixedUpdate()
    {
        MyInput();
        MovePlayer();

        // esc key to get to menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput == 0 && verticalInput == 0)
        {
            moveDirection = Vector3.zero;
        }
    }

    private void MovePlayer()
    {
        // move in the direction your facing
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * Time.deltaTime);
    }
    

}
