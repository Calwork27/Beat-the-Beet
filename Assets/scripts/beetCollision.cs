using UnityEngine;

public class beetCollision : MonoBehaviour
{
    public int playerHealth;
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(collision.gameObject);
        playerHealth--;
        if (playerHealth <= 0)
        {
            Debug.Log("im ded");
        }

        Destroy(this.gameObject);

        void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(this.gameObject);
        }
    }
}
