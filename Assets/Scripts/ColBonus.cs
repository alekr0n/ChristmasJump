using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColBonus : MonoBehaviour
{
    public Text coin;

    void Update()
    {
        coin.text = PlayerPrefs.GetInt("money").ToString();
    }
}
