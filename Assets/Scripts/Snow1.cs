using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow1 : MonoBehaviour
{
    public GameObject fon;
    private float speedX = 0.2f, speedY = 0.6f;
    private float ResX = 1f, ResY = 3f;

    void FixedUpdate()
    {
        fon.transform.position = new Vector2(fon.transform.position.x - speedX * Time.deltaTime, fon.transform.position.y - speedY * Time.deltaTime);

        if (fon.transform.position.y < -9f)
        {
            fon.transform.position = new Vector2(ResX, ResY);
        }
    }
}
