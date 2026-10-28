using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 2;
    //if enemy is hit by a bullet, reduce its health
    //if enemy health gets too low, they should die

    //this function doesn't run if the collider is set to trigger
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    //this function DOES run if the collider is set to trigger
    public GameObject healthPack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //if the enemy hits a bullet
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("OUCH!");
            health -= 1;
            //If enemy health gets too low, destroy them
            if (health <= 0)
            {
                Destroy(gameObject);

                int r = Random.Range(1, 11);
                if (r >= 5)
                {
                    Instantiate(healthPack, transform.position, Quaternion.identity);
                }
            }

            //CHALLENGE:
            //modify enemy health to have a CHANCE of dropping a health pack object
            //create a new script on the player bullet to DESTROY the player bullet
            //when it hits anything whose tag != (this means NOT equal) to the player
        }
    }
}
