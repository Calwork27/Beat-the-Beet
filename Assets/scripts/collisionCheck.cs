using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    public GameObject player;
    public GameObject shield;
    private void Start()
    {
        shield = GameObject.Find("Shield");
        player = GameObject.Find("Player");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playerHealth>().health--;
            int pHealth = collision.gameObject.GetComponent<playerHealth>().health;
            if (pHealth == 0)
            {
                collision.gameObject.GetComponent<playerHealth>().Death();
            }
            Debug.Log(pHealth);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Shield")
        {
            Destroy(this.gameObject);
        }
    }
    
}
