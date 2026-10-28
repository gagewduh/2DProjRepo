using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public int coins = 100;
    public int swordlevel = 1;

    // Update is called once per frame
    void Update()
    {
        UpgradeSword();
    }
    void UpgradeSword()
    {
        if (coins >= 50)
        {
            swordlevel = swordlevel++;
            coins = coins - 50;
            Debug.Log("You Have Upgraded Your Sword!");
        }
        if (coins < 50)
        {
            Debug.Log("Get Your money up");
        }
    }
}
