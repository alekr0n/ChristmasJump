using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;
    private float RandY = -4f;
    public static int TempNPlatf = 1;

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for(int i = 0; i < 11; i++)
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            RandY = RandY + 1f;
            SpawnerPosition.y = RandY;

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }
}
