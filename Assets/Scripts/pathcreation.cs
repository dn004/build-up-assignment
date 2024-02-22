using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pathcreation : MonoBehaviour
{
    public GameObject player;
    public GameObject[] placeholders;
    public float speed;
    public Button nextButton; // Reference to UI Button

    delegate void MyDelegate();

    bool buttonClicked = false;

    MyDelegate[] delegates;
    int currentRoomIndex = -1; // Index of the current room

    void Start()
    {
        // Initialize delegates
        delegates = new MyDelegate[]
        {
            ToRoom1,
            ToRoom2,
            ToRoom3,
            ToRoom4,
            ToRoom5
        };

        // Attach NextButtonClicked method to the onClick event of the button
        nextButton.onClick.AddListener(NextButtonClicked);
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }

    void Update()
    {
        // Check if the current room index is within the bounds of the delegates array
        if (buttonClicked == true && currentRoomIndex < delegates.Length)
        {
            // Invoke the delegate corresponding to the current room index
            delegates[currentRoomIndex]();
        }
    }

    // Method to handle button click event
    void NextButtonClicked()
    {
        // Move to the next room if the button is clicked
        buttonClicked = true;
        currentRoomIndex++;
        
    }

    void ToRoom1()
    {
        // Move the player to the target position
        player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[3].transform.position, speed * Time.deltaTime);
        // Rotate the player towards the specified coordinates 
        //player.transform.Rotate(new Vector3(0.0f, -85.61f, 0.0f)); 

        //Set the players position to specific position
        //player.transform.position = placeholders[3].transform.position;
        // Set the player's rotation to the specified Euler angles
        player.transform.eulerAngles = new Vector3(0.0f, -85.61f, 0.0f);
    }

    void ToRoom2()
    {
        player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[5].transform.position, speed * Time.deltaTime);
        player.transform.eulerAngles = new Vector3(0.0f, 97.829f, 0.0f);
    }

    void ToRoom3()
    {
        player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[8].transform.position, speed * Time.deltaTime);
        player.transform.eulerAngles = new Vector3(0.0f, -85.32f, 0.0f);
    }

    void ToRoom4()
    {
        player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[15].transform.position, speed * Time.deltaTime);
        player.transform.eulerAngles = new Vector3(0.0f, 3.319f, 0.0f); 
    }

    void ToRoom5()
    {
        player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[14].transform.position, speed * Time.deltaTime);
        player.transform.eulerAngles = new Vector3(0.0f, -174.0f, 0.0f); 
    }


    void RotatePlayerTowards(Vector3 targetEulerAngles)
    {
        // Rotate the player by the specified Euler angles
        player.transform.Rotate(targetEulerAngles);
    }


    /*void RotatePlayerTowards(Vector3 targetPosition)
    {
        // Calculate the direction from the player to the target position
        Vector3 direction = targetPosition - player.transform.position;
        // Calculate the rotation needed to face the target position
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        // Smoothly rotate the player towards the target rotation
        player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, speed * Time.deltaTime);
    }
    */
}
