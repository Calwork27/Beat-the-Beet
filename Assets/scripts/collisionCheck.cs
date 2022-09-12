using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    public GameObject player;
    public GameObject shield;
    public GameObject score;
    public float distance;
    public float perfectThreshHold;
    private void Start()
    {
        shield = GameObject.Find("Shield");
        player = GameObject.Find("Player");
        score = GameObject.Find("scoreText");
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
            distance = Vector2.Distance(collision.gameObject.transform.position, gameObject.transform.position);
            print(distance);
            if (distance <= 0.99)
                {
                    score.GetComponent<points>().score += 250;
                }
            Destroy(this.gameObject);
        }
    }
    
}
