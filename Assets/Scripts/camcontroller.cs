using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontroller : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);

    private void Start()
    {
        // Locking the cursor to the middle of the screen & making it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    

    void Update()
    {
        // Keep the camera with the player
        transform.position = player.transform.position + offset;


       /* // Check if the game is paused or in a menu
        if (IsGamePausedOrInMenu())
        {
            // Unlock the cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            return; // Exit the Update method early if the game is paused or in a menu
        }
        else
        {
            // Ensure the cursor is locked
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        */

        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Rotation up to 90 degrees

        // Rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    /*bool IsGamePausedOrInMenu()
    {
        // Implement your logic to determine if the game is paused or in a menu
        bool isPausedOrInMenu = false;

        return isPausedOrInMenu;
    }
    */
}
