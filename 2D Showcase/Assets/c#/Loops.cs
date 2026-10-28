using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //any time looping through something, heavy on processing
        //for loop is most common form of looping through repeated behaviour
        //as an example: loop through all the enemies, shoot at nearest on
        //for loop anatomy: first, has a starting variable, then a break condition, finally an operation that happens each loop

        for (int i = 0; i < 10; i++)
        {
            //for each number starting at 0 and going up to 9, will do something
           // Debug.Log(i);
        }
        //i want to add up all the numbers from 1 to 75 using a for loop
        int sum = 0;
        for (int i =17; i <= 192; i++)
        {
            //sum up the values
            sum += i;
        }
        //Debug.Log(sum);

        //i want to know the location of all enemies in the level
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //[] means its an array of the variable
        //an array is a collection of variables of the same type
        //this is an array (collection) of all the the GameObjects tagged as enemy in the scene
        //now we can loop through the array to debug.log their locations
        for (int i = 0; i < enemies.Length; i++)
        {
            //as long as i is less than the length of the array (how many variables are in it)
            Debug.Log(enemies[i].transform.position);
            //arrays start counting at Index = 0 (index means the location)
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
