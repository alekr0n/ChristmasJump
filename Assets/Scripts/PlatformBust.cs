using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBust : MonoBehaviour
{
    public float jumpForce;
    private float RandY, RandX;
    public GameObject platP, snowP, fadeP, bustP, shipP;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            //Изменить на обычную платформу
            Player.instance.playerRigid.velocity = Vector2.up * jumpForce;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-1.7f, 1.7f);
            float RandY = transform.position.y + 12f;

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
                Replace(bustP, platP);
            }
            else if (NPlat >= 7 && NPlat <= 9)
            {
                Replace(bustP, snowP);
            }
        }
        else if (PlatformGenerate.TempNPlatf >= 7 && PlatformGenerate.TempNPlatf <= 9)
        {
            if (NPlat >= 1 && NPlat <= 3)
            {
                Replace(bustP, platP);
            }
            else if (NPlat >= 7 && NPlat <= 9)
            {
                Replace(bustP, snowP);
            }
        }
        else
        {
            if (NPlat >= 1 && NPlat <= 3)
            {
                Replace(bustP, platP);
            }
            else if (NPlat >= 4 && NPlat <= 6)
            {
                Replace(bustP, fadeP);
            }
            else if (NPlat >= 7 && NPlat <= 9)
            {
                Replace(bustP, snowP);
            }
            else if (NPlat >= 11 && NPlat <= 16)
            {
                Replace(bustP, shipP);
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
