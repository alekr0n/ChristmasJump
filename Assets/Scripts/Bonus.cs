using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    private int money;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            money = PlayerPrefs.GetInt("money") + 1;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.Save();
            float RandX = Random.Range(-1.7f, 1.7f);
            float RandY = transform.position.y + Random.Range(10f, 15f);
            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collision.CompareTag("DeadZone"))
        {
            float RandX = Random.Range(-1.7f, 1.7f);
            float RandY = transform.position.y + Random.Range(10f, 15f);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
