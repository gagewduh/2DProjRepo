using UnityEngine;

public class RandomAssignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        int ATK = 5;
            ATK = Random.Range(1, 101);
        Debug.Log(ATK);
        if (ATK > 20)
        {
            Debug.Log("you beat the enemy!");
                };
        if (ATK <= 20)
        {
            Debug.Log("The enemy beat you!");
                };
        if (ATK >= 90) ;
        {
            Debug.Log("Ultra mega drop spawned!!!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
