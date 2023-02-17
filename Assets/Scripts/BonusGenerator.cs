using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGenerator : MonoBehaviour
{
    public GameObject BonusPrefab;

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 3; i++)
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnerPosition.y = Random.Range(-2f, 10f);

            Instantiate(BonusPrefab, SpawnerPosition, Quaternion.identity);
        }
    }
}
