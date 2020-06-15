using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    //player transform
    private Transform playerTransform; 
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        //current camera position
        Vector3 temp = transform.position;

        //make player and camera align together 
        temp.x = playerTransform.position.x;

        //set temp to current position
        transform.position = temp;
    }
}
