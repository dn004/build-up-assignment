using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
    public float rotationSpeed = 10f;  // Adjust sensitivity as needed

    Vector3 moveDirection;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(moveDirection * speed * Time.deltaTime);

        // Handle touchpad rotation on supported platforms
        if (Input.touchSupported)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 delta = touch.deltaPosition;

            // Rotate around the Y-axis based on horizontal touchpad movement
            transform.Rotate(Vector3.up, delta.x * rotationSpeed * Time.fixedDeltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}