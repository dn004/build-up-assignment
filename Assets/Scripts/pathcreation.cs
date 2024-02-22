using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pathcreation : MonoBehaviour
{
    public GameObject player;
    public GameObject[] placeholders;
    public float speed;
    public Button nextButton; // Reference to UI Button

    delegate void MyDelegate();

    MyDelegate[] delegates;
    int currentRoomIndex = 0; // Index of the current room

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

    void Update()
    {
        // Check if the current room index is within the bounds of the delegates array
        if (currentRoomIndex < delegates.Length)
        {
            // Invoke the delegate corresponding to the current room index
            delegates[currentRoomIndex]();
        }
    }

    // Method to handle button click event
    void NextButtonClicked()
    {
        // Move to the next room if the button is clicked
        currentRoomIndex++;
    }

    void ToRoom1()
    {
        int[] Room1 = {0, 1, 2, 3};

        for (int i = 0; i < Room1.Length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[3].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom2()
    {
        int[] Room2 = {2, 1, 4, 5};

        for (int i = 0; i < Room2.Length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[5].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom3()
    {
        int[] Room3 = {4, 1, 6, 7, 8};

        for (int i = 0; i < Room3.Length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[8].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom4()
    {
        int[] Room4 = {7, 6, 1, 8, 0 , 8, 9, 10, 11, 12, 13};

        for (int i = 0; i < Room4.Length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[15].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom5()
    {
        int[] Room5 = {12, 14};

        for (int i = 0; i < Room5.Length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[14].transform.position, speed * Time.deltaTime);
        }
    }
}
