using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour
{
    public static Player instance;
    
    float horizontal;
    public Rigidbody2D playerRigid;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3939073", false);
        }

        if(instance == null)
        {
            instance = this;
        }
    }

    void FixedUpdate()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

        if(Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        
        if(Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        playerRigid.velocity = new Vector2(Input.acceleration.x * 15f, playerRigid.velocity.y);
        
        if(transform.position.x < -3f)
        {
            transform.position = new Vector2(3f, transform.position.y);
        }

        if (transform.position.x > 3f)
        {
            transform.position = new Vector2(-3f, transform.position.y);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if(collision.collider.name == "DeadZone")
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show("video");
            }
            SceneManager.LoadScene(2);
        }
    }
}
