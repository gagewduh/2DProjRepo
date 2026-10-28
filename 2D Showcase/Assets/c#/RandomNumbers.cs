using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int r = 0;
        //Random.Range for integers is inclusive on the min,
        //eclusive on the max. so (1, 100); can give us 1 - 99
        r = Random.Range(1, 101);
        Debug.Log(r);
        //floats using Random.Range are inclusive on the min AND the max 
        //so (1f, 100f) can give any value from 1.0 and 100.0
        float rand = Random.Range(1f, 100f);
        Debug.Log(rand);
        if (rand > 50f)
        {
            Debug.Log("Special loot drop!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
