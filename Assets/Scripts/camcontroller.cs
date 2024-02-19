using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontroller : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
   
    void Update()
    {
        transform.position = player.transform.position + offset;
        
    }
}
