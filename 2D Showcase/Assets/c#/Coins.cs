using UnityEngine;
using UnityEngine.SceneManagement;

public class Coins : MonoBehaviour
{
    public int coins = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Debug.Log("I got my bands up!");
            coins = coins + 1;
        }
        if (collision.gameObject.tag == "bigcoin")
        {
            Debug.Log("Woah, Major Money Alert!!");
            coins = coins + 5;
        }
    }

}
