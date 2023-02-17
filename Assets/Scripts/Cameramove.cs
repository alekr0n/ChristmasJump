using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform playerPos;

    void Update()
    {
        if(playerPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerPos.position.y, transform.position.z);
        }
    }
}
