using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFade : MonoBehaviour
{
    private float RandY, RandX;
    public GameObject platP, snowP, fadeP, bustP, shipP;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            RandX = Random.Range(-1.7f, 1.7f);
            RandY = transform.position.y + 12f;

            transform.position = new Vector3(RandX, RandY, 0);

            SwitchPlatform();
        }
    }

    public void SwitchPlatform()
    {
        int NPlat = Random.Range(1, 16);

        if ((PlatformGenerate.TempNPlatf >= 4 && PlatformGenerate.TempNPlatf <= 6) || (PlatformGenerate.TempNPlatf >= 11 && PlatformGenerate.TempNPlatf <= 16))
        {
            if (NPlat >= 1 && NPlat <= 3)
            {
                Replace(fadeP, platP);
            }
            else if (NPlat == 10)
            {
                Replace(fadeP, bustP);
            }
            else/* if (NPlat >= 7 && NPlat <= 9)*/
            {
                Replace(fadeP, snowP);
            }
        }
        else if (PlatformGenerate.TempNPlatf >= 7 && PlatformGenerate.TempNPlatf <= 9)
        {
            if (NPlat >= 1 && NPlat <= 3)
            {
                Replace(fadeP, platP);
            }
            else if (NPlat == 10)
            {
                Replace(fadeP, bustP);
            }
            else /*if (NPlat >= 7 && NPlat <= 9)*/
            {
                Replace(fadeP, snowP);
            }
        }
        else
        {
            if (NPlat >= 1 && NPlat <= 3)
            {
                Replace(fadeP, platP);
            }
            else if (NPlat >= 7 && NPlat <= 9)
            {
                Replace(fadeP, snowP);
            }
            else if (NPlat == 10)
            {
                Replace(fadeP, bustP);
            }
            else if (NPlat >= 11 && NPlat <= 16)
            {
                Replace(fadeP, shipP);
            }
        }
        PlatformGenerate.TempNPlatf = NPlat;
    }

    public void Replace(GameObject a, GameObject b)
    {
        Instantiate(b, a.transform.position, Quaternion.identity);
        Destroy(a);
    }
}
