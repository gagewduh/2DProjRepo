using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this is a code comment
        //debug is a class someone else wrote
        //debug has a funvtion callled log
        //log receives any variables in the () and spits it out to the console
        //the end of this line has a ; which marks  the end of a single line of code
        Debug.Log("Hello World!");
        //this is called a variable declaration. We create a new variable
        //first we say what type of variable it is, then we name it and set it
        //to a value
        int health = 10;
        //after we declare health, we don't need to say its type anymore
        health = 17;
        health = health + 1;
        //floats store decimal values, always end in an f
        float critchance = 0.1f;
        //any operation we can do to an int, we can do to a float
        critchance = critchance + 0.1f;
        string name = "John";
        Debug.Log("Hello, " + name);
        //bools are a true or false value, used in lots of logic checks
        bool isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
