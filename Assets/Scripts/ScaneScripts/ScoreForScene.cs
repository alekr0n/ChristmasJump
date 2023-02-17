using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreForScene : MonoBehaviour
{
    public Text txt;
    private string sc;

    void Update()
    {
        txt.text = "Score: " + Score.score.ToString();
    }
}
