using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform cam;
    public Text txt;
    public static float score = 0f;

    void Update()
    {
        score = Mathf.Round(cam.transform.position.y * 10);
        txt.text = "Score: " + score.ToString(); 
    }
}
