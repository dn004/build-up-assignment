/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public player;


public class pathcreation : MonoBehaviour
{

    public GameObject player;

    public GameObject[] placeholders;

    public float speed;

    public Button nextButton;
    int roomnumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(NextButtonClicked);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(roomnumber < 4 && nextButton.onClick)
        {

        }


        
        
    }




    void ToRoom1()
    {
        int[] Room1 = {0, 1, 2, 3};

        for (int i = 0; i < Room1.length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[Room1[i]].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom2()
    {
        int[] Room2 = {2, 1, 4, 5};

        for (int i = 0; i < Room2.length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[Room2[i]].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom3()
    {
        int[] Room1 = {4, 1, 6, 7, 8};

        for (int i = 0; i < Room3.length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[Room3[i]].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom4()
    {
        int[] Room4 = {7, 6, 1, 8, 0 , 8, 9, 10, 11, 12, 13};

        for (int i = 0; i < Room4.length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[Room4[i]].transform.position, speed * Time.deltaTime);
        }
    }

    void ToRoom5()
    {
        int[] Room5 = {12, 14};

        for (int i = 0; i < Room5.length; i++)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, placeholders[Room5[i]].transform.position, speed * Time.deltaTime);
        }
    }



    
}
*/