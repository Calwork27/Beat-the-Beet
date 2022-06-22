using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public GameObject deathText;
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        deathText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Death()
    {
        // You enter stuff here that needs to happen on death!
        deathText.SetActive(true);
    }
}
