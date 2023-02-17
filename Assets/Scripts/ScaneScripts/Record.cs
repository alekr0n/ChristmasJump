using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Text txt;

    void Update()
    {
        if(PlayerPrefs.GetFloat("Rec") < Score.score)
        {
            PlayerPrefs.SetFloat("Rec", Score.score);
            PlayerPrefs.Save();
        }
        txt.text = "Record: " + PlayerPrefs.GetFloat("Rec").ToString();
    }
}
