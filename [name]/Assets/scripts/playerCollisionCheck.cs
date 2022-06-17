using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisionCheck : MonoBehaviour
{
    public int playerHealth;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        playerHealth--;
        if(playerHealth <= 0)
        {
            Debug.Log("im ded");
        }

    }
}
