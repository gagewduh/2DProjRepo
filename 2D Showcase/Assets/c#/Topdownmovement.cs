using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Topdownmovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //first check for user input to see if we should move
        //user input in top down: checks vertical and horizontal input
        //w, s should move player up/down
        //a, d should move the player to the sides
       // float moveX = Input.GetAxis("Horizontal");
        //Debug.Log(moveX);
        //if we have user input, move the player based on that input

    }

    public float movespeed = 5f;
    public void OnMove(InputValue value)
    {
        //Vector2 is a special variable that stores x, y as floats
        //Debug.Log(value.Get<Vector2>());
        //use this vector 2 to make the player move
        //the speed variable depends on the type of game you're making
        GetComponent<Rigidbody2D>().linearVelocity = value.Get<Vector2>() * movespeed;
    }

}
