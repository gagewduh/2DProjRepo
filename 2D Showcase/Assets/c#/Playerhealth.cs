using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public int health = 70;
    //the text object we want to update
    public TMP_Text text;
    //when the player hits an enemy
    //reduce the player health
    //then, if health is to low you die, aka reload the level
    void Start()
    {
        text.text = "Health:" + health;
        //CHALLENGE
        //update your player collectable code to display how many collectables you have
        //change player 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("I hit an enemy!");
            health -= 20;
            //update my health text
            text.text = "Health: " + health;
            if (health <= 0)
            {
                Debug.Log("You died!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (collision.gameObject.tag == "HealthPack")
        {
            health += 1;
            text.text = "Health: " + health;
        }
    }
}
